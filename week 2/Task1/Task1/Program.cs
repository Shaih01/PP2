using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        public static bool Ispalin(string s)
        {
            int j = s.Length - 1;

            for(int i = 0; i < s.Length / 2; i++)
            {
                if(j < i)
                {
                    break;
                }
                if(s[i] != s[j])
                {
                    return false;
                }
                j--;
            }
            return true;
        }

        public static void Srsw()
        {
            StreamReader sr = new StreamReader("C:/Users/Шаихислам/source/repos/week2/Task1/Task1/input.txt");
            String s = sr.ReadToEnd();
            sr.Close();

            StreamWriter sw = new StreamWriter("C:/Users/Шаихислам/source/repos/week2/Task1/Task1/output.txt");

            if (Ispalin(s))
            {
                sw.WriteLine("Yes");
            }
            else
                sw.WriteLine("No");
            sw.Close();
        }


        static void Main(string[] args)
        {
            Srsw();
        }
    }
}
