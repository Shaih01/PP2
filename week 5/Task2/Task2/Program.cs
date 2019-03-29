using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Task2
{
    public class Temp
    {
        [XmlArray("GRADES")]
        public List<Mark> grades;
        public Mark points;
        public Mark grade;
        public Temp()
        {
            grades = new List<Mark>();
        }

        public Temp(Mark points, Mark grade)
        {
            this.points = points;
            this.grade = grade;
            grades = new List<Mark>();
        }
        
        public void Save(Temp ma)
        {
            FileStream fs = new FileStream("Mark.xml", FileMode.Truncate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Temp));
            xs.Serialize(fs, ma);
            fs.Close();
        }
        public override string ToString()
        {
            return "Your points is: " + grades[0].points + ". And your grade is " + grades[0].grade;
        }
    }

    public class Mark   
    {
        public int points;
        public string grade;
        
        public Mark(){}
        public Mark(int points)
        {
            this.points = points;
            if (this.points >= 0 && this.points <= 100)
                this.points = points;
            GetLetter();
        }

        public override string ToString()
        {
            return "Your points: " + points + "." + " Your grade is " + grade;
        }

        public void GetLetter()
        {
            if (points <= 100 && points >= 95)
            {
                grade = "A";
            }
            if (points <= 94 && points >= 90)
            {
                grade = "A-";
            }
            if (points <= 89 && points >= 85)
            {
                grade = "B+";
            }
            if (points <= 84 && points >= 80)
            {
                grade = "B";
            }
            if (points <= 79 && points >= 75)
            {
                grade = "B-";
            }
            if (points <= 74 && points >= 70)
            {
                grade = "C+";
            }
            if (points <= 69 && points >= 65)
            {
                grade = "C";
            }
            if (points <= 64 && points >= 60)
            {
                grade = "C-";
            }
            if (points <= 59 && points >= 55)
            {
                grade = "D+";
            }
            if (points <= 54 && points >= 50)
            {
                grade = "D";
            }
            if (points < 50)
            {
                grade = "F";
            }
            if (points > 100)
            {
                grade = "A++++++";
            }
        }
    }
    class Program
    {
        public static void F1()
        {
            Mark m = new Mark(32);
            Mark x = new Mark(43);
            Temp temp = new Temp();
            temp.grades.Add(m);
            temp.grades.Add(x);
            temp.Save(temp);
            Console.WriteLine(m);
            Console.WriteLine(x);
        }

        public static void F2()
        {
            FileStream fs = new FileStream("Mark.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Temp));
            Temp m1 = xs.Deserialize(fs) as Temp;
            for(int i = 0; i < m1.grades.Count; i++)
            {
                Console.WriteLine(m1.grades[i]);
            }
            fs.Close();
        }

        public static void Main(string[] args)
        {
            //F1();
            F2();
        }
    }
}
