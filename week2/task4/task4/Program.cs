using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace task4
{
    class Program
    {
        static void createcopydelete()
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Тамерлан\Desktop\pp2\week2\examplefortask3\Tamerlan\filesfortask4.txt"); // создаем поток, входные данные берутся из файла, указанного в пути 

            sw.WriteLine("SOLUTION projectile motion"); // записываем в поток "SOLUTION projectile motion"

            sw.Close(); // закрываем файл

            File.Copy(@"C:\Users\Тамерлан\Desktop\pp2\week2\examplefortask3\Tamerlan\filesfortask4.txt", @"C: \Users\Тамерлан\Desktop\pp2\week2\examplefortask3\mama\filesfortask4copy.txt"); // копируем файл из одной папки в другую
            File.Delete(@"C:\Users\Тамерлан\Desktop\pp2\week2\examplefortask3\Tamerlan\filesfortask4.txt"); //удаляем изначальный файл

        }
        static void Main(string[] args)
        {
            createcopydelete(); // вызываем функцию createcopydelete
        }
    }
}