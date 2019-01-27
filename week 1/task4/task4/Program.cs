using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] s = new string[100,100];//Обьявляем 2d массив
            
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    s[i, j] = "[*]";//Заполняем массив 
                }
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(s[i, j]);//Выводим значения массива
                }
                Console.WriteLine();//После каждого выполнения внутренего цикла начинаем с новой строки
            }
            Console.ReadKey();
        }
    }
}
