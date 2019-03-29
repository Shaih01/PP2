using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                threads[i] = new Thread(Name);
                Console.WriteLine("Введите имя потока #" + (i + 1));
                threads[i].Name = Console.ReadLine();
            }
            foreach(Thread t in threads)
            { 
                t.Start();
            }  
        }
        static void Name()
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Имя текущего потока " + Thread.CurrentThread.Name);
            }
        }
    }
}
/*
 * 
            Thread[] threads = new Thread[3];
            for(int i = 0; i < 3; i++)
            {
                threads[i] = new Thread(new ThreadStart(Name));
                Console.WriteLine("Enter the name of the thread " + (i + 1));
                threads[i].Name = Console.ReadLine();
            }
            foreach(Thread t in threads)
            {
                t.Start();
            }

    */