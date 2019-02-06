using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        public static void Spaces(int level)
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write("      ");
            }
        }
        public static void Ex(DirectoryInfo dir, int level)
        {
            foreach (FileInfo f in dir.GetFiles())
            {
                Spaces(level);
                Console.WriteLine(f.Name);
            }
            foreach(DirectoryInfo d in dir.GetDirectories())
            {
                Spaces(level);
                Console.WriteLine(d.Name);
                Ex(d, level + 1);
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("C:/Users/Шаихислам/source/repos/week2/Task3");
            Ex(dir, 0);
        }
    }
}