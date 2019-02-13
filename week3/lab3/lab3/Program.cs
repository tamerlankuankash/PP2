using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace lab3
{
    class Farmanndger
    {
        public int cursor;
       public  string path;
        DirectoryInfo Dir = null;
        FileSystemInfo[] FSI = null;
        FileSystemInfo fn = null;
        public int size;
        
        public Farmanndger()
        {

        }
        public Farmanndger(string path)
        {
            this.path = path;
            cursor = 0;
        }
        public void Color(FileSystemInfo f,int index)
        {
            if (cursor == index)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                fn = f;
            }
           else if (f.GetType() == typeof(FileInfo))
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Dir = new DirectoryInfo(path);
            FSI = Dir.GetFileSystemInfos();
            for(int k = 0; k < FSI.Length; k++)
            {
                if (FSI[k].Name[0] == '.')
                    continue;
                Color(FSI[k],k);
                Console.WriteLine(FSI[k]);
            }
        }
        public void Up()
        {
            cursor --;
            if (cursor < 0)
            {
                cursor = size - 1;
            }
        }
        public void Down()
        {
            cursor++;
            if (cursor == size)
            {
                cursor = 0;
            }
        }
        public void Delete()
        {
            if (fn.GetType() == typeof(DirectoryInfo))
            {
                cursor = 0;
                Directory.Delete(fn.FullName);
            }
            else
            {
                cursor = 0;
                File.Delete(fn.FullName);
            }
        }
        public void open()
        {
            if (fn.GetType() == typeof(DirectoryInfo))
            {
                cursor = 0;
                path = fn.FullName;
            }
            else
            {
                StreamReader SR = new StreamReader(fn.FullName);

                Console.WriteLine(SR.ReadToEnd());
                SR.Close();
                Console.ReadKey();
                Console.Clear();

            }
        }
        public void flashback()
        {
            Console.Clear();
            string name = Console.ReadLine();
            Console.Clear();
            string copPath = Path.Combine(Dir.FullName, name);
            if (fn.GetType() == typeof(DirectoryInfo))
            {
                Directory.Move(fn.FullName, copPath);
            }
            else
            {
                File.Move(fn.FullName, copPath);
            }
        }

        public void Calc()
        {
            DirectoryInfo D = new DirectoryInfo(path);
            FileSystemInfo[] f = D.GetFileSystemInfos();
            size = f.Length;
            for(int k = 0; k < f.Length; k++)
            {
                if (f[k].Name[0]=='.')
                   size--;
                
            }
        }
        public void Start()
        {
            while (true)
            {
                Calc();
                Show();
                ConsoleKeyInfo Konsol = Console.ReadKey();
                if (Konsol.Key == ConsoleKey.UpArrow)
                {
                    Up();
                }
                else if (Konsol.Key == ConsoleKey.DownArrow)
                {
                    Down();
                }

               else if (Konsol.Key == ConsoleKey.Backspace)
                {
                    Delete();
                }

                else if (Konsol.Key==ConsoleKey.Enter)
                {
                    open();

                }
                else if (Konsol.Key==ConsoleKey.Escape)
                {
                    flashback();
                }

            }
        }
       
         
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Тамерлан\Desktop";
            Farmanndger Far = new Farmanndger(path);
            Far.Start();
            Console.ReadKey();
        }
    }
}
