using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        static void qwerty()
        {
            StreamReader a = new StreamReader(@"C:\Users\Тамерлан\Desktop\pp2\week2\input.txt"); // указываем путь для файла, откуда программа считывает полиндром
            string s = a.ReadToEnd(); // создаем переменную типа string, где будут храниться данные с .txt файла 
            bool q = true; // создаем переменную типа bool, с начальным значением 1, эта переменная будет отвечать за выходной параметр (либо true, либо false)

            for (int i = 0; i < s.Length; ++i) // создаем цикл, где переменная пробегается по каждому элементу от 0 до длины переменной s

            {
                if (s[i] != s[s.Length - 1 - i]) // задаем условие, если элемент с индексом i не равен элементу с индексом, длина переменной -1 и - i-й элемент
                {

                    q = false; // если условие выполняется, выходное значение false

                }
            }

            if (q) // задается условие, если переменная q=true
                Console.WriteLine("Yes"); // получаем ответ "Yes"
            else // если же q=false
                Console.WriteLine("No"); // ответ "No"
            a.Close(); // закрываем файл



        }
        static void Main(string[] args)
        {
            qwerty(); // вызываем функцию qwerty
            Console.ReadKey();
        }
    }
}