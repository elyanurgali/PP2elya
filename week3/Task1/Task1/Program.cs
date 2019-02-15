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
            cursor = 0;     //находимся в самом верху
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
            if (cursor == sz) //последняя строка у нас size-1 и если мы нажали на down и его сделал +, то курсор будет равен сайз
                cursor = 0;
        }
            
        public void Color(FileSystemInfo fs, int index)
        {
            if (index==cursor) //мы находимся на том файле, где у нас стоит курсор
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.White;
            }
             else if (fs.GetType() == typeof(DirectoryInfo)) //GetType - возвращает тип файлов (DirectoryInfo/File)
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

        public void Show(string path)  //Здесь мы хотим показать весь список содержимое в папке на экран. path-путь до какой-то папке
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileSystemInfo [] fileSystemInfos = directory.GetFileSystemInfos(); //FileSystemInfos - array of Files and Directories
            sz = fileSystemInfos.Length;  //количество файлов.
            int index = 0;

            foreach (FileSystemInfo fs in fileSystemInfos)
            {
                if (fs.Name.StartsWith("."))   //не показывать скрытные файлы
                    continue;
                   this.Color(fs, index);  //мы передаем туда fs, в зависимости от fs мы красим, и вводим это fs.name на экран

              Console.WriteLine(index+1 + ". " + fs.Name );
                index++;
            }
        }
       
            public void Start(string path)
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            while (consoleKey.Key != ConsoleKey.Escape)  //делает бесконечных циклов до тем, пока мы Escape не нажмем
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear(); //берет последний програм который давали и полностью красить этот цвет вашему цвету
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
            FarManager farManager = new FarManager();   //мы создаем экземпляр FarManager
            farManager.Start("C:/Users/админ/Desktop/ICT");

        }
    }
}
