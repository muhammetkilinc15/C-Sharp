using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = 15, temp;
            int[] arr = new int[n];
            Console.Write("Ramdoly created array with length 15 is : \n");
            for (int i = 0; i < n; i++)
            {
                int number = random.Next(-100, 101);
                arr[i] = number;
                Console.Write(number + " ");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j+1] < arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            Console.Write("\n\nSorted array with length 15 is : \n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int min=arr[0],max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            int q1 = arr[arr.Length / 4];
            Console.Write("\n\nQ1 pf the array is : " + q1);
            int q3 = arr[3*arr.Length / 4];
            Console.Write("\n\nQ3 pf the array is : " + q3);
            int ıqr = q3 - q1;
            Console.Write("\n\nIQR pf the array is : " + ıqr);
            Console.Write("\n\nMinumum of the array is : " + min);
            Console.Write("\n\nMaximum pf the array is : " + max);
            int median = arr[arr.Length/2];
            Console.Write("\n\nMedian pf the array is : " + median);
            Console.ReadKey();
        }
    }
}
