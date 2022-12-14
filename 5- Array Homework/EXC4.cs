using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[15];
            Console.WriteLine("Newly created list is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                int number = random.Next(0, 51);
                arr[i] = number;
                Console.Write(number + " ");
            }
            // I found the greatest number  
            int max = 0, counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    counter = i; // I found the index number of the largest
                }
            }
            // I found the second greatest number !!
            int second = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i!=counter) // The index numbers of the largest value and the second largest value cannot be the same.
                {
                    if (second < arr[i])
                    {
                        second = arr[i];
                    }
                }
            }
            Console.WriteLine("\n\nGreates item : " + max);
            Console.Write("\n\nSecond greatest item : " + second);
            Console.ReadLine();
        }
    }
}
