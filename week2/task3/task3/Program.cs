using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {
        static void q1(int level)
        {
            for (int i = 0; i < level; i++) // создаем цикл, где переменная пробегается от 0 до входной переменной level
            {
                Console.Write("   ");
            }
        }


        static void q2(DirectoryInfo dir, int level)
        {
            foreach (FileInfo file in dir.GetFiles()) // создаем цикл, для обращения к файлам, находящимся в определенной папке
            {
                q1(level + 1); // вызываем функцию q1, с входным данным, увеличенным на единицу
                Console.WriteLine(file.Name); // выводим на консоль название файла

            }


            foreach (DirectoryInfo direct in dir.GetDirectories()) // создаем цикл, для обращения к папкам, находящимся в папке
            {
                q1(level + 1); // вызываем функцию q1, с входным данным, увеличенным на единицу
                Console.WriteLine(direct.Name); // выводим на консоль название папки
                q2(direct, level + 2); // вызываем функцию q2
            }

        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Тамерлан\Desktop\pp2\week2\examplefortask3"); // задаем путь для папки
            Console.WriteLine(dir.Name); // выводим на консоль наименование папки
            q2(dir, 0); // вызываем функцию q2
            Console.ReadKey();
        }
    }
}