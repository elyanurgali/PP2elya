using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
        {
            public string name;
            public string id;
            public string year;

            public Student (string name, string id, int year)
            {
                this.name = name;
                this.id = id;
            
            }

            public void Print()
            {
                int year = 0;
                for (int i = 0; i < 5; i++)
                {
                    year++;
                    Console.WriteLine("NAME:" + name + " " + "ID:" + id + " " + "Year of study:"  + year + " ");
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {

                Student s = new Student ("Nurgali Eleonora", "18BD111398" , 0);

                s.Print();
            }
        }
    }
