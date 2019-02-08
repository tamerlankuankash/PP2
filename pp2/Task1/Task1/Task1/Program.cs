using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool Primes(int num)
        {
            if (num <= 1)
                return false;
            for(int k = 2; k < num;k++)
            {
                if (num % k == 0)
                    return false;
            }
            return true;

            
        }
            






        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string s = Console.ReadLine();
            string[] number = s.Split();

            for(int i=0;i<n;i++)
            {
                a[i] = int.Parse(number[i]);
            }
              








            for(int i=0;i<n;i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
