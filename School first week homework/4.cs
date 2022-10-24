using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = 649;
            int divideByEleven = number % 11;
            String condition;
            condition = divideByEleven == 0 ? "Yes" : "NO";

            Console.WriteLine(condition);



        }
    }
}
