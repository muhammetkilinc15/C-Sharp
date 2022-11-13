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


            int a, b , change;

            Console.WriteLine("Enter value a : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value b : ");
            b = int.Parse(Console.ReadLine());

            change = a; ;
            a = b;
            b = change;

            Console.WriteLine("Value of a is: {0} and value of b is: {1}", a, b);

            Console.ReadKey();

















        }
    }
}
