using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User enter the lenght of array
            Console.Write("Enter the length of the array : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];    
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter the value: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum , sumMax = 0;        
            for (int i = 0; i < arr.Length; i++)
            {
                sum = arr[i]; 
                for (int j = i+1; j < arr.Length; j++)
                {                  
                    sum += arr[j]; 
                    if (sum >= sumMax)
                    {
                        sumMax = sum;                     
                    }
                }                
            }
            Console.WriteLine("Maximum sum : " + sumMax);
            Console.ReadLine();
        }
    }
}
