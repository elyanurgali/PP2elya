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
        public static bool Prime(int k) // It is used to declare variables to store the Boolean values: true and false.
                                        //PUBLIC means no access restrictions
        {
            if (k <= 1) return false; //if element of array is equal or less than 1 then it is not a Prime number 
            for (int i = 2; i < k; i++)
            {
                if (k % i == 0) return false; //According to the condition which given above, when element is divided by index(starting from 2)without remainder then this element is not a Prime number
            }
            return true; //otherwise it is a Prime number 
        }
        static void Main(string[] args)
        {                                      //call the above function in the main part
            int n = int.Parse(Console.ReadLine());  //All that is entered from the console is by default of the string type, and the int.Parse method is used to convert the string to an integer.
            int[] a = new int[n]; //It allocates that much space according to the size of array (value of n)
            string s = Console.ReadLine();  //enter elements of array in string form
            a = s.Split(' ').Select(int.Parse).ToArray(); ////Convert a string to an int Array (also we can write it like this (Int32.Parse))
            int b = 0; //new variable which count the quantity of Prime numbers
            for (int i = 0; i < a.Length; i++) //enter elements of array according to the value of n
            {
                if (Prime(a[i]) == true) b++; //if k is Prime number then add 1 to b;
            }
            Console.WriteLine(b); //output the quantity of Prime numbers
            for (int i = 0; i < a.Length; i++)
            {
                if (Prime(a[i]) == true) Console.Write(a[i] + " "); //output the elements of array which are considered as a prime number
            }
        }
    }
}


