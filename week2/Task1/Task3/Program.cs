using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void DirectoryInDesktop(DirectoryInfo tree, int level)   //method with two parametres
        {
            FileInfo[] files = tree.GetFiles();   //GetFiles-array of files
            DirectoryInfo[] directories = tree.GetDirectories(); 

            foreach (DirectoryInfo dInfo in directories)
            {
                for (int i = 0; i < level; i++) //level Printspace
                    Console.Write(" ");
                Console.WriteLine(dInfo.Name);
                DirectoryInDesktop(dInfo, level + 2);
            }
            foreach (FileInfo file in files)
            {
                for (int i = 0; i < level; i++)
                    Console.Write(" ");
                Console.WriteLine(file.Name);
            }

        }
        static void Main(string[] args)
        {
            DirectoryInfo Directory = new DirectoryInfo("C:/Users/админ/Desktop/pp2");
            DirectoryInDesktop(Directory, 0);
        }
    }
}
