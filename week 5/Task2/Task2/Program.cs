using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Task2
{
    public class Mark
    {
        public int points;
        public string grade;

        public Mark() { }

        public Mark(int points)
        {
            if (this.points >= 0 && this.points <= 100)
                this.points = points;
            else
                this.points = 0;
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
        }

        public override string ToString()
        {
            return "Your points: " + points + "." + " Your grade is " + grade;
        }

    }

    class Program
    {
        public static void F1()
        {
            Mark m = new Mark(97);
            FileStream fs = new FileStream("Mark.xml", FileMode.Truncate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Mark));
            xs.Serialize(fs, m);
            m.GetLetter();
            Console.WriteLine(m);
            fs.Close();
        }

        public static void F2()
        {
            FileStream fs = new FileStream("Mark.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Mark));
            Mark m1 = xs.Deserialize(fs) as Mark;
            Console.WriteLine(m1);
            fs.Close();
        }

        public static void Main(string[] args)
        {
            F1();
            //F2();
        }
    }
}