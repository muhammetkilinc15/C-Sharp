using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            int seven = 7, five = 5;
            if (number > 1 && number <= 500)
            {
                if (number % five == 0 && number % seven == 0)
                {
                    Console.WriteLine("Number {0} is divisible by both {1} and {2}.", number, seven, five);
                }
                else if (number % five == 0)
                {
                    Console.WriteLine("Number {0} is divisible by {1} . ",number,five);
                }
                else if (number % seven == 0)
                {
                    Console.WriteLine("Number {0} is divisible by {1} .", number, seven);
                }
                else
                {
                    Console.WriteLine("Number {0} is not divisible by {1} or {2} .",number,five,seven);
                }
            }
            else
            {
                if (number > 500)
                {
                    Console.WriteLine("Error! Number {0} is bigger than 500",number);
                }
                else
                {
                    Console.WriteLine("Error! Number {0} is smaller than 0.", number);
                }
            }
            Console.ReadKey();
        }
    }
}
