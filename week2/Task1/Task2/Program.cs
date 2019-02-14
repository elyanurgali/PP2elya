using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static bool Prime(int k)   //Function to check the number is prime or not
        {
                if (k <= 1) return false;
            if (k == 2) return true;
                for (int i = 2; i < k; i++)
                {                                          //algorithm to check
                    if (k % i == 0) return false;
                }
                return true;
            }
            static void Main(string[] args)
            {
                StreamReader sr = new StreamReader("C:/Users/админ/Desktop/pp2/week2/Task1/Task2/input.txt"); // StreamReader to read text from a file "input.txt".
                string s = sr.ReadToEnd(); //Reads all characters from the current position to the end of the stream.
                                           // string s = Console.ReadLine();
                int[] a = s.Split().Select(int.Parse).ToArray(); //Convert a string to a int Array
                List<int> l = new List<int>(); //Creating list to store prime numbers
                for (int i = 0; i < a.Length; i++)
                {
                    if (Prime(a[i]) == true)
                        l.Add(a[i]); //adding prime numbers to the list
                }
                StreamWriter sw = new StreamWriter("C:/Users/админ/Desktop/pp2/week2/Task1/Task2/output.txt");
                for (int i = 0; i < l.Count; i++)
                {
                    sw.Write(l[i] + " ");

                }
                sw.Close();
            }
        }
    }
