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
            double literPrice = 4.15d;
            float stepOne =  3 / 7f;
            float stepTwo = (14600 / 1000f);
            float stepThree = stepOne * stepTwo;
            float stepFour = (float)literPrice * stepThree;

            Console.WriteLine("Liter per kilometer is " + stepOne + " liters");
            Console.WriteLine("Destination in kilometer is " + stepTwo + " kilometers");
            Console.WriteLine("Liter of gas is " + stepThree + " $");
            Console.WriteLine("Total cost is " + stepFour + " $");
            



        }
    }
}
