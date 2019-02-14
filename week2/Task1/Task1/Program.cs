using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {       
            static bool Palindrome(string s)
            {
                for (int i = 0; i < s.Length / 2; i++)
                {
                    if (s[i] != s[s.Length - i - 1]) return false;
                }
                return true;
            }
            static void Main(string[] args)
            {
                StreamReader sr = new StreamReader("C:/Users/админ/Desktop/input.txt");
                string s = sr.ReadToEnd();
                sr.Close();
                if (Palindrome(s)) Console.WriteLine("Yes");
                else Console.WriteLine("No");
            }
        }
    }

