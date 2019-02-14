using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "NewFile.txt";
            string folder1 = "C:/Users/админ/Desktop/path";
            string folder2 = "C:/Users/админ/Desktop/path1";
            string path1 = Path.Combine(folder1, filename);
            string path2 = Path.Combine(folder2, filename);
            File.Copy(path1, path2, true);
            //Copu(string,string,Boolean) - Copies an existing file to a new file.
                                                   //path1-The file to copy
                                                   //path2-The name of the destination file. 
         File.Delete(path1);
            Console.WriteLine("File is copied and original file is deleted succesfully");
        }
    }
}