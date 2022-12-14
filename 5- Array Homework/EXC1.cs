using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int n = 15;
            int[] arr = new int[15];
            Console.Write("Ramdomy created array with length 15 is :\n ");
            for (int i = 0; i < n; i++)
            {
                int number = ran.Next(-100, 101);
                arr[i] = number;
                Console.Write(number + " ");
            }          
            int temp;
            // I use the bubble short 
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
            Console.ReadKey();
        }
    }
}
