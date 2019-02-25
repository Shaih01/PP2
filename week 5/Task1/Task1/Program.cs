using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace Task1
{
    public class Complex_number
    {
        public int a;
        public int b;

        public Complex_number() { }
        public Complex_number(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        
        public override string ToString()
        {   
            return a + "/" + b;
        }
        public void Save(Complex_number cn)
        {
            FileStream fs = new FileStream("complex_numbers.xml", FileMode.Truncate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Complex_number));
            xs.Serialize(fs, cn);
            fs.Close();
        }
        public static Complex_number operator +(Complex_number a,Complex_number b)
        {
            Complex_number c = new Complex_number();
            c.a = a.a + b.a;
            c.b = a.b + b.b;
            return c;
        }
        public static Complex_number operator -(Complex_number a, Complex_number b)
        {
            Complex_number c = new Complex_number();
            c.a = a.a - a.b;
            c.b = a.b - b.b;
            
            return c;
        }
        public static Complex_number operator *(Complex_number a, Complex_number b)
        {
            Complex_number c = new Complex_number();
            c.a = a.a * a.b;
            c.b = a.b * b.b;
            return c;
        }
        public static Complex_number operator /(Complex_number a, Complex_number b)
        {
            Complex_number c = new Complex_number();
            c.a = a.a / b.b;
            c.b = a.b / b.a;
            return c;
        }
    }

    class Program
    {
        public static void F1()
        {
            Complex_number cn = new Complex_number(12, 3);
            FileStream fs = new FileStream("complex_numbers.xml", FileMode.Truncate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Complex_number));
            xs.Serialize(fs, cn + cn);
            Console.WriteLine(cn + cn);
            fs.Close();
        }

        public static void F2()
        {
            FileStream fs = new FileStream("complex_numbers.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Complex_number));
            Complex_number cn1 = xs.Deserialize(fs) as Complex_number;
            Console.WriteLine(cn1 + cn1);
            fs.Close();
        }
        
        static void Main(string[] args)
        {
            F1();
            //F2();
        }
    }
}