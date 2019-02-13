using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {

        static void Primelab2()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Тамерлан\Desktop\pp2\week2\inputtask2.txt"); // задаем путь, для .txt файла, откуда берутся входные значения
            StreamWriter sw = new StreamWriter(@"C:\Users\Тамерлан\Desktop\pp2\week2\output.txt"); // задаем путь, для .txt файла, куда будут записываться простые числа из первого файла

            string s = sr.ReadLine(); // создаем переменную типа string, куда записываются числа из файла с входными значениями
            string[] array = s.Split(); // создаем массив, указывая элементы, которые разделены между собой пробелом


            for (int i = 0; i < array.Length; ++i) // создаем цикл, где переменная пробегается от 0 до длины массива
            {
                bool b = true; // создаем переменную типа bool, изначально равную 1
                int n = int.Parse(array[i]); // создаем переменную, куда будут записываться элементы из массива, преобразованные в тип int, для дальнейших мат.операций
                if (n <= 1) // задаем условие, если переменная n меньше или равна 1
                    b = false; // переменная bool дает 0 (false)
                for (int k = 2; k < n; ++k) // задаем цикл, где переменная k пробегается от 2 до n
                {
                    if (n % k == 0) // задаем условие, если переменная n делится без остатка на переменную k
                        b = false; // переменная bool дает 0 (false)
                }


                if (b == true) // задаем условие, если переменная bool=true
                {
                    sw.Write(n + " "); // число записывается в .txt файл, предназначенный для выходных значений
                }




            }
            sr.Close(); // закрываем .txt файл со входными данными
            sw.Close(); // закрываем .txt файл, куда записывали простые числа


        }
        static void Main(string[] args)
        {
            Primelab2(); // вызываем функцию Primelab2
            Console.ReadKey();
        }
    }
}