using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Student
    {
       public string Name;
       public string Surname;
       public  int Year;
       public Student(string Name,int Year,string Surname)
        {
           this.Name = Name;
            this.Year = Year;
            this.Surname = Surname;
        }
        public void ShowName()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Surname);
            Console.WriteLine(Year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*  int n = int.Parse(Console.ReadLine());
              int[] ar = new int[n];
              string s = Console.ReadLine();
              string[] Str = s.Split();

              for(int k = 0; k < n; k++)
              {
                  ar[k] = int.Parse(Str[k]);
              }
              for (int k=0; k < n; k++){
                  Console.Write(ar[k] + " ");
              }*/
            /*  Student st1 = new Student();
              st1.Name = Console.ReadLine();
              st1.Surname = "dasd";
              st1.Year = 5;
              st1.ShowName();*/
            Student st2 = new Student("Temir", 4,"qdqd");
            Console.WriteLine(st2.Name);
            Console.ReadKey();
        }
    }
}
