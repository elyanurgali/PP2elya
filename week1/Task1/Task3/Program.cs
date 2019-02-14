using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //All that is entered from the console is the string type, and the int.Parse method is used to convert the string to an integer.

            int[] arr = new int[n]; //new array with given size
            string s = Console.ReadLine();
            arr = s.Split(' ').Select(int.Parse).ToArray(); //making array from elements firstly splited by space from entered string and after converted to integer type 

            for (int i = 0; i < arr.Length; ++i) //enter elements of array according to the value of n
            {
                for (int j = 0; j < 2; ++j) //every element is repeated
                {
                    Console.Write(arr[i] + " "); //According to two conditions(for) we will get a result
                }
            }
        }
    }
}

