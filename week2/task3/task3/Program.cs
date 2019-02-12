using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {
        static void q1(int level)
        {
            for(int i=0; i<level; i++)
            {
                Console.Write("   ");
            }
        }


        static void q2(DirectoryInfo dir,int level)
        {
            foreach (FileInfo file in dir.GetFiles())
            {
                q1(level + 1);
                Console.WriteLine(file.Name);

            }


            foreach (DirectoryInfo direct in  dir.GetDirectories())
            {
                q1(level + 1);
                Console.WriteLine(direct.Name );
                q2(direct, level + 2);
            }
           
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Тамерлан\Desktop\pp2\week2\examplefortask3");
            Console.WriteLine(dir.Name);
            q2(dir, 0);
            Console.ReadKey();
        }
    }
}
