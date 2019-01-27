using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taks1
{
    class Program
    {
        public static bool Isprime(int x)//Создали метод для того чтобы выяснить является ли число простым(праймом)
        {
            if (x == 2)//чтобы лишний раз не проверять сразу вернем тру если цисло равно 2
            {
                return true;
            }
            if(x == 1)//Если число 1 сразу  вернем фолс вместо того чтобы идти по всему методу
            {
                return false;
            }
            for(int i = x - 1; i >= 2; i--)//Находим Простые числа
            {
                if(x % i == 0)
                {
                    return false;      
                }
            }
            return true;//Если так или иначе число не вернуло фолс то значит оно прайм поэтому мы все равно в конце возвращаем тру

            
        }


        static void Main(string[] args)
        { 
            //arr нужен просто чтобы принять разделеные цифры а затем перевести их в int и передать их значение массиву a
            int size;
            size = Convert.ToInt32(Console.ReadLine());//Переводим вводные данные из типа стринг в тип инт
            string s = Console.ReadLine();
            int finalsize = size;//Создали переменую чтобы в конце вывести число праймов в массиве
            string[] arr = s.Split();//Разделяем массив по пробелу
            int[] a = new int[100];//Обьявляем массив

            for (int i = 0; i < size; i++)
            {
                a[i] = int.Parse(arr[i]);//Переносим из типа стринг в тип инт
            }
            for (int i = 0; i < size; i++)
            {
                if (!Isprime(a[i]))
                {
                        finalsize--;//Считаем количество чисел в массиве которое простое(прайм)
                }
            }
            Console.WriteLine(finalsize);
            for (int i = 0; i < size; i++)
            {
                if (Isprime(a[i]))//Проверяем если возращает тру выводит на консоль наше число через пробел
                {
                    Console.Write(a[i] + " ");
                }
                }
            Console.ReadKey();//Чтобы консоль не закрылась сразу после ввода можно еще просто ctrl + f5 вместо f5 но так быстрей

        }
    }
}
