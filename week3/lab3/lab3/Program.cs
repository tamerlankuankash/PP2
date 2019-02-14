using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace lab3
{
    class Farmanndger 
    {
      
        public int cursor;
        public string path;
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

        public void Color(FileSystemInfo f, int index)
        {
            if (cursor == index)                               //ввел условия если наш курсор совпадет с номером файла то будет открашивать в выбранный цыет
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                fn = f;
            }
            else if (f.GetType() == typeof(FileInfo)) // если тип файла файл то есть не фолдер, открашиваем его в магнетто цвет
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Blue; // иначе если не файл а  папка то окрашиваем его в белый
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void Show()// фукция которая будет выводить нам элементы которые содержаться по указанному пути 
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Dir = new DirectoryInfo(path);
            FSI = Dir.GetFileSystemInfos();
            for (int k = 0; k < FSI.Length; k++) // условия чтобы системные папки не выводились на экран 
            {
                if (FSI[k].Name[0] == '.')
                    continue;
                Color(FSI[k], k);
                Console.WriteLine(FSI[k]);
            }
        }

        
        public void Up()  // если курсор будет проваливаться за пределы нуля то возращаем курсор на последнйи элемент
        {
            cursor--;
            if (cursor < 0)
            {
                cursor = size - 1;
            }
        }
        public void Down() // если курсор выйдет за пределы файлов которые показаны, курсор окажется на первом элементе 
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
                Directory.Delete(fn.FullName,true);//пишем тру чтобы мог удалять папку с содержимым если без логичекого тру то не смогу удалить папку если в нем содержаться файлы
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
                path = fn.FullName;// если открываем папку курсор на начальную позицию и теперь нам нужен другой путь так как мы в другом файле значит присваеваем новый путь
            }
            else
            {
                StreamReader SR = new StreamReader(fn.FullName); // если это не папка то это файл и читаем содержимео файла 

                 Console.WriteLine(SR.ReadToEnd());
                 SR.Close();
                 Console.ReadKey();
                 Console.Clear();
                 
               // Process.Start(fn.FullName);
            }
        }
        public void flashback()
        {
            cursor = 0;
            path = Dir.Parent.FullName; // зашли в папку нужно вернуться, берем предыдущий путь до папки открытья 
        }
        public void Rename()
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

        
        /* фукнция будет считать нам размер то есть количесво файлов не системных  */

            public void Calcsize()
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
        
        public void Close()
        {
            Environment.Exit(0);
        }

        public void Start()
        {
            while (true)
            
            {
                Calcsize();
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

               else if (Konsol.Key == ConsoleKey.Delete)
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
                else if (Konsol.Key==ConsoleKey.F2)
                {
                    Rename();
                }
                else if(Konsol.Key==ConsoleKey.F4)
                {
                    Close();
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
