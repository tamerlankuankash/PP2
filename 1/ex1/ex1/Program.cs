using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(2, 4);
            Console.ReadKey();
        }
    }
    class Calculator
    {
        public static void Add(int x, int y )
        {
            int z = x + y;
            Console.WriteLine($"summa {x} and {y} equal {z}");
        }
    }
}
