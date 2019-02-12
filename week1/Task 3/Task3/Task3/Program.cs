using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {

        static int[] SecondArr(int[] arr) 
        {
            int[] array = new int[2 * arr.Length]; // создаем массив типа int, с увеличенным количеством элементов дважды
            int k = -1; // создаем переменную, по умолчанию со значением -1
            for (int i = 0; i < arr.Length; i++) // создаем цикл, где переменная пробегается от 0 до длины массива, для записи элемента дважды
            {
                k++; // добавляем +1 к переменной
                array[k] = arr[i]; // элемент массива с индексом переменной приравнием к элементу входного массива с индексом переменной цикла 
                k++; // повторяем действие дважды
                array[k] = arr[i];
            }
            return array; // возвращает массив типа int
        }


        static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine()); // в новое переменную сохраняем, то что записано на консольную строку и конвертируем в тип int
                string s = Console.ReadLine(); // в переменную типа string также сохраняем то, что записано на консольную строку
                string[] ar = s.Split(); // создаем массив типа string, где он разделяем элементы переменной s, которые записаны через пробел
                int[] array = new int[n]; // создаем массив типа int, с количеством элементов заданных нами вначале
                for (int i = 0; i < n; i++) // создаем цикл, где переменная пробегается от 0 до количества элементов, где элементы массива записываются от массива ar
                {
                    array[i] = int.Parse(ar[i]); // записываются элементы, конвертируя элементы типа string в int
                }
                int[] finalarr = SecondArr(array); // создаем массив, куда записываются числа из массива, возвращаемые в предыдущем методе
                for (int k = 0; k < finalarr.Length; k++)
                {
                    Console.Write(finalarr[k] + " "); // выводит на экран новый массив с удвоенными элементами
                 }
                Console.ReadKey();
            }

        }
    }