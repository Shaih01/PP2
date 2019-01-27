using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student//Создаем класс с новыми типами данных
{
    string name;
    string id;
    int year_of_study;
  
    Student(){}
    //Создали контруктор который по умолчанию. Просто если создать еще один контруктор нужно будет создать тот что по умолчанию заново
    Student(string new_name, string new_id)//Конструктор бладоря которому можно задать значения без использования сеттера
    {
        name = new_name;
        id = new_id;
    }
    void set_name(string new_name)//Метод с помощью которого можно поменять значения переменной "name"
    {
        name = new_name;
    }
    void set_id(string new_id)
    {
        id = new_id;
    }
    void increment_the_year_of_study(int year)//Cоздали метод который увеличивает значения заданой перемены "год" и присвает его к переменой год обучения
    {
        year_of_study = year + 1;
    }
}

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Функция мэйн пуста ибо по заданию я должен был работать только с классом Student
        }
    }
}
