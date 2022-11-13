using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 65 - 90 Uppercase
            // 97 - 122 lowecase 

            char chOne, chTwo, chThree, chFour, chFive;

            Console.WriteLine("Enter the 1st character :");
            chOne = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd character :");
            chTwo = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 3rd character :");
            chThree = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 4th character :");
            chFour = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 5th character :");
            chFive = char.Parse(Console.ReadLine());

            int ch1 = (int)chOne;
            int ch2 = (int)chTwo;
            int ch3 = (int)chThree;
            int ch4 = (int)chFour;
            int ch5 = (int)chFive;

            int upperCase = 0, lowerCase = 0;
            int condition;

            condition = ch1 >= 65 && ch1 <= 90 ? upperCase++ :
                ch1 >= 97 && ch1 <= 122 ? lowerCase++ : upperCase++;

            condition = ch2 >= 65 && ch2 <= 90 ? upperCase++ :
                ch2 >= 97 && ch2 <= 122 ? lowerCase++ : upperCase++;

            condition = ch3 >= 65 && ch3 <= 90 ? upperCase++ :
                ch3 >= 97 && ch3 <= 122 ? lowerCase++ : upperCase++;

            condition = ch4 >= 65 && ch4 <= 90 ? upperCase++ :
                ch4 >= 97 && ch4 <= 122 ? lowerCase++ : upperCase++;

            condition = ch5 >= 65 && ch5 <= 90 ? upperCase++ :
                ch5 >= 97 && ch5 <= 122 ? lowerCase++ : upperCase++;


            string conditionString = upperCase > lowerCase ? "uppercase" : "lowercase";


            Console.WriteLine("You entered {0} lowercase letters", lowerCase);
            Console.WriteLine("You entered {0} uppercase letters", upperCase);
            Console.WriteLine("You entered more {0} letters.", conditionString);
            Console.ReadKey();













        }
    }
}
