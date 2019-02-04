using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task2
{
    class Program
    {
        public static bool Isprime(int a)
        {
            if(a == 1)
            {
                return false;
            }
            if(a == 2)
            {
                return true;
            }
            for(int i = a - 1; i >= 2; i--)
            {
                if(a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void Srsw()
        {
            StreamReader sr = new StreamReader("C:/Users/Шаихислам/source/repos/week2/Task2/Task2/input.txt");

            String s = sr.ReadToEnd();
            string[] arr = s.Split();
            int[] a = new int[s.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                a[i] = int.Parse(arr[i]);
            }
            sr.Close();

            StreamWriter sw = new StreamWriter("C: /Users/Шаихислам/source/repos/week2/Task2/Task2/output.txt");
            for(int i = 0; i < s.Length; i++)
            {
                if(Isprime(a[i]) && a[i] != 0)
                {
                    sw.Write(a[i] + " ");
                }
            }
            sw.Close();
        }

        static void Main(string[] args)
        {
            Srsw();
        }
    }
}
