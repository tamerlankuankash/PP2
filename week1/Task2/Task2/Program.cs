using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student 
       {

        public string name;
        public string Id;
        public int Year;
    
        public Student(string name, string Id) // конструктор из двух параметров
        {
            this.name = name;
            this.Id = Id;

        }

          public string NAME() // метод, который будет возращать имя
        {
            return name;
        }


        public string ID()  // метод, который будет возращать айдишку студента
        {
            return Id;

        }
        public int YEAR() // метод, который будет возращать год увеличенный 
        {
            return ++ Year;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Student INFORMATION = new Student(Console.ReadLine(),Console.ReadLine());

            Console.WriteLine(INFORMATION.NAME()); // вызывает функцию NAME, чтобы записать и вывести имя на экран
            Console.WriteLine(INFORMATION.ID()); // вызывает функцию ID, чтобы записать и вывести айдишку на экран
            Console.WriteLine(INFORMATION.YEAR()); // вызывает функцию YEAR, чтобы записать и вывести год обучения на экран
            Console.ReadKey();
        }
    }
}3