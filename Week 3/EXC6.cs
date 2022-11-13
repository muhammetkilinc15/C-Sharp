using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int password;
            string computerNameOrId, student;
            Console.Write("Enter you password: ");
            password = int.Parse(Console.ReadLine());

            double dellPrice = 2500, asusPrice = 1500, monsterPrice = 1000, hpPrice = 1750;
            if (password / 1000 > 0 && password / 1000000 < 1)
            {
                Console.Write("Enter a brand name or computer ID: ");
                computerNameOrId = Console.ReadLine();
                if (computerNameOrId == "Dell" || computerNameOrId == "234")
                {
                    Console.Write("Are you a student? (Y/N): ");
                    student = Console.ReadLine();
                    if (student == "Y")
                    {
                        dellPrice = dellPrice * 80 / 100;
                        Console.WriteLine("Total price is {0}$ ", dellPrice);
                    }
                    else
                    {
                        Console.WriteLine("Total price is {0}$ ", dellPrice);
                    }
                }
                else if (computerNameOrId == "Asus" || computerNameOrId == "536")
                {
                    Console.Write("Are you a student? [Y/N): ");
                    student = Console.ReadLine();
                    if (student == "Y")
                    {
                        asusPrice = asusPrice * 80 / 100;
                        Console.WriteLine("Total price is {0}$ ", asusPrice);
                    }
                    else
                    {
                        Console.WriteLine("Total price is {0}$ ", asusPrice);
                    }
                }
                else if (computerNameOrId == "Monster" || computerNameOrId == "862")
                {
                    Console.Write("Are you a student? [Y/N): ");
                    student = Console.ReadLine();
                    if (student == "Y")
                    {
                        monsterPrice = monsterPrice * 80 / 100;
                        Console.WriteLine("Total price is {0}$ ", monsterPrice);
                    }
                    else
                    {
                        Console.WriteLine("Total price is {0}$ ", monsterPrice);
                    }
                }
                else if (computerNameOrId == "HP" || computerNameOrId == "601")
                {
                    Console.Write("Are you a student? [Y/N): ");
                    student = Console.ReadLine();
                    if (student == "Y")
                    {
                        hpPrice = hpPrice * 80 / 100;
                        Console.WriteLine("Total price is {0}$ ", hpPrice);
                    }
                    else
                    {
                        Console.WriteLine("Total price is {0}$ ", hpPrice);
                    }
                }
                else
                {
                    Console.WriteLine("There is no matching name or ID according to your input.");
                }

            }
            else
            {
                Console.WriteLine("Password is incorrect!");
            }

            Console.ReadKey();

        }
    }
}
