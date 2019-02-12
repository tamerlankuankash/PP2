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
            StreamWriter sw = new StreamWriter(@"C:\Users\Тамерлан\Desktop\pp2\week2\examplefortask3\Tamerlan\filesfortask4.txt");

            sw.WriteLine("SOLUTION projectile motion");

            sw.Close();

            File.Copy(@"C:\Users\Тамерлан\Desktop\pp2\week2\examplefortask3\Tamerlan\filesfortask4.txt", @"C: \Users\Тамерлан\Desktop\pp2\week2\examplefortask3\mama\filesfortask4copy.txt");
            File.Delete(@"C:\Users\Тамерлан\Desktop\pp2\week2\examplefortask3\Tamerlan\filesfortask4.txt");

        }
        static void Main(string[] args)
        {
            createcopydelete();
        }
    }
}
