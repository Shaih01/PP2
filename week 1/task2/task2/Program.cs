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
    //Создали контруктор который по умолчанию просто если создать еще контруктор нужно будет создать
    Student(string new_name, string new_id, int new_year_of_study)//Конструктор бладоря которому можно задать значения без использования сета
    {
        name = new_name;
        id = new_id;
        year_of_study = new_year_of_study;
    }
    void set(string new_name, string new_id, int new_year_of_study)//Метод с помощью которого можно поменять значения переменых 
    {
        name = new_name;
        id = new_id;
        year_of_study = new_year_of_study;
    }
    string get_name()//Создал три метода которые возвращяют значения переменых
    {
        return name;
    }
    string get_id()
    {
        return id;
    }
    int get_year_of_study()
    {
        return year_of_study;
    }
}

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
