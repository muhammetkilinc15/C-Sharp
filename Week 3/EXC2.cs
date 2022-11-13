using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selection;
            int numberTwo, numberOne;
            Console.WriteLine("1-Addition\n2-Subtraction\n3-Multiplication\n4-Devision");
            Console.Write("Select an operation : ");
            selection = int.Parse(Console.ReadLine());
            Console.Write("Enter first integer : ");
            numberOne = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer : ");
            numberTwo = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Console.WriteLine("Result of the operation is " + (numberOne + numberTwo));
                    break;
                case 2:
                    Console.WriteLine("Result of the operation is " + (numberOne - numberTwo));
                    break;
                case 3:
                    Console.WriteLine("Result of the operation is " + (numberOne * numberTwo));
                    break;
                case 4:
                    if (numberTwo != 0)
                    {
                        Console.WriteLine("Result of the operation is " + (numberOne / numberTwo));
                    }
                    else
                    {
                        Console.WriteLine("A number cannot be divided by zero");
                    }
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
