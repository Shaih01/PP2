using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Svetofor
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread threads = new Thread(Print);
            threads.Start();
        }
        static void Print()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("RED");
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("YELLOW");
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("GREEN");
                Thread.Sleep(200);
            }
        }
    }
}