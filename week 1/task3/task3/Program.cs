using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        public static int[] Change(int[] nums)//Метод созданый для того чтобы дублировать каждую цифру в массиве
        {
            int[] massiv = new int[nums.Length * 2];//Создаем новый массив с удвоенным размером.
            
            for(int i = 0, j = 0; i < nums.Length; i++, j++)
            {
                massiv[j] = nums[i];//Передаем ему значения 
                j++;
                massiv[j] = nums[i];
                
            }
            return massiv;//Возвращаем полученный массив
        }

        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());//Вводим размер массива и затем переносим его в тип int
            string s = Console.ReadLine();
            string[] arr = s.Split();//Разделяем введеный текст по пробела

            int[] a = new int[n];//Создаем новый массив для хранения массива интеджеров

            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(arr[i]);//Инициализируем массив а
            }
            
            Console.WriteLine();
            int [] massiv = Change(a);//Вызываем функцию и отдаем ей наш массив а . Затем функция возращает нам новый массив уже измененый
            for(int i = 0; i < massiv.Length; i++)
            {
                Console.Write(massiv[i] + " ");//И просто выводим наш финальный массив на экран
            }
            Console.ReadKey();
        }
    }
}
