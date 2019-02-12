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
            StreamReader sr = new StreamReader(@"C:\Users\Тамерлан\Desktop\pp2\week2\inputtask2.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\Тамерлан\Desktop\pp2\week2\output.txt");

            string s = sr.ReadLine();
            string[] array = s.Split();


            for (int i = 0; i < array.Length; ++i)
            {
                bool b = true;
                int n = int.Parse(array[i]);
                if (n <= 1)
                    b = false;
                for (int k = 2; k < n; ++k)
                {
                    if (n % k == 0)
                        b = false;
                }
            

                if (b==true)
                {
                    sw.Write(n + " ");
                }


                
              
            }
            sr.Close();
            sw.Close();


        }
        static void Main(string[] args)
        {
            Primelab2();
            Console.ReadKey();
        }
    }
}
