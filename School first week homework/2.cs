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

            int number = 547964;

            int firstFaceValue = (number / 100000);
            int thirdFaceValue = (number / 1000) % 10;
            int secondPlaceValue = ((number / 10000) % 10) * 10000;
            int fourthPlaceValue = ((number / 100) % 10) * 100;
            int fifhtPlaceValue = ((number / 10) % 10) * 10;
            int sixthFaceVAlue = number % 10;
            int multiply = fifhtPlaceValue * sixthFaceVAlue;

            Console.WriteLine("Face value of the first digit is " + firstFaceValue);
            Console.WriteLine("Face value og the third digit is " + thirdFaceValue);
            Console.WriteLine("Place value of the second digit is " + secondPlaceValue);
            Console.WriteLine("Place value of the second digit is " + fourthPlaceValue);
            Console.WriteLine("Result of the multiplication is : " + fifhtPlaceValue + " × " + sixthFaceVAlue + " : " + multiply);




        }
    }
}
