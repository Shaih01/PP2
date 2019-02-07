using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = "C:/Top-level folder/path/t.txt";
            string path1 = "C:/Top-level folder/path1/t.txt";
            FileInfo f = new FileInfo(path);

            if(f.Exists)
            {
                f.CopyTo(path1);
                f.Delete();
            }
        }
    }
}