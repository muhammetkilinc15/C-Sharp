using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id;
            do
            {
                Console.Write("Enter your id number : ");
                id = Console.ReadLine();
                if (ısValid(id))
                {
                    Console.WriteLine("You entered an invalid ID number ");
                }
                else
                {
                    Console.WriteLine("You entered an invalid ID number");
                    Console.WriteLine("Try again! ");
                }
            } while (ısValid(id) == false);
        }
        static bool ısValid(string id)
        {
            bool check = false;
            if (id.Length == 11)
            {
                if (isNumeric(id) == true)
                {
                    int sumEven = 0, sumOdd = 0;
                    for (int i = 1; i <= 9; i++)
                    {
                        int valueX = getValue(id, i);

                        if (i % 2 == 0)
                        {
                            sumOdd += valueX;
                        }
                        else
                        {
                            sumEven += valueX;
                        }
                    }
                    int value10 = (sumOdd * 7 - sumEven) % 10;
                    if (getValue(id, 10) == value10)
                    {
                        int value11 = (sumEven + sumOdd + value10) % 10;
                        if (getValue(id, 11) == value11)
                        {
                            check = true;
                        }
                    }
                }
            }
            return check;
        }
        static bool isNumeric(string str) 
        {
            bool checker = true;
            foreach (char n in str)
            {
                if (n < '0' || n > '9')
                {
                    checker = false;
                    break;
                }
            }
            return checker;
        }
        static int getValue(string str, int index)
        {
            return str[index - 1];
        }
    }
}
