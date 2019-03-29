using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_2
{
    public class MyThread
    {
        public Thread threadField;

        public MyThread(string name)
        {
            threadField = new Thread(Name);
            threadField.Name = name;
        }

        public void startThread()
        {
            threadField.Start();
        }
        public void Name()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("{0} outputs {1}", threadField.Name, i);
                Thread.Sleep(200);
            }
            Console.WriteLine("{0} this thread ended", threadField.Name);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyThread t1 = new MyThread("Thread 1");
            MyThread t2 = new MyThread("Thread 2");
            MyThread t3 = new MyThread("Thread 3");

            t1.startThread();
            t2.startThread();
            t3.startThread();

            Console.Read();
        }
    }
}
    