using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine()); // создаем переменную типа int, куда записываем данные считанные с консольной строки
            string[,] arr = new string[n, n]; // создаем матрицу с размерностью nxn
           
            for (int i = 0; i < n; i++) // создаем цикл, где переменная пробегается от 0 до количества элементов
            {
                for (int j = 0; j <= i; j++) // создаем цикл, где новая переменная пробегается от 0 до предыдущей переменной
                {
                    arr[i, j] = "[*]"; // элементы матрицы записываются 
                    Console.Write(arr[i, j]); // выводим элменеты 
                }
                Console.WriteLine();
            }

          

            Console.ReadKey();
        }
    }
}