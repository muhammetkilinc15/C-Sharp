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

            int numberOne = 12;
            int numberTwo = 12;
            int result = numberOne ^ numberTwo;
            String condition;
            condition = result == 0 ? "True" : "False";

            Console.WriteLine(condition);



        }
    }
}
