using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class FarManager
    {
        public int cursor;
        public int sz;
        public FarManager()
        {
            cursor = 0;
        }

        public void Up()
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;
        }
        public void Down()
        {
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }
            
        public void Color(FileSystemInfo fs, int index)
        {
            if (index==cursor)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.White;
            }
             else if (fs.GetType() == typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
        }

        public void Show(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileSystemInfo [] fileSystemInfos = directory.GetFileSystemInfos();
            sz = fileSystemInfos.Length;
            int index = 0;

            foreach (FileSystemInfo fs in fileSystemInfos)
            {
                if (fs.Name.StartsWith("."))   //скрытные файлы
                    continue;
                   this.Color(fs, index);

              Console.WriteLine(index+1 + ". " + fs.Name );
                index++;
            }
        }
       
            public void Start(string path)
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            while (consoleKey.Key!=ConsoleKey.Escape)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Show(path);
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.UpArrow)
                    this.Up();
                if (consoleKey.Key == ConsoleKey.DownArrow)
                    Down();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FarManager farManager = new FarManager();
            farManager.Start("C:/Users/админ/Desktop/ICT");

        }
    }
}