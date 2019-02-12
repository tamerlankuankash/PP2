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
            StreamReader a = new StreamReader(@"C:\Users\Тамерлан\Desktop\pp2\week2\input.txt");
            string s = a.ReadToEnd();
            bool q = true;

            for (int i = 0; i < s.Length; ++i)

            {
                if (s[i] != s[s.Length - 1 - i])
                {

                    q = false;

                }
            }

            if (q)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            a.Close();



        }
        static void Main(string[] args)
        {
            qwerty();
            Console.ReadKey();
        }
    }
}
