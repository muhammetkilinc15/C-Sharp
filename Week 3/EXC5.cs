using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double consumed;
            Console.Write("Enter total units consumed: ");
            consumed = double.Parse(Console.ReadLine());

            double bill = 0, netbill=0;
            if (consumed <= 50)
            {
                bill = consumed * 0.50;
            }
            else if (consumed <= 150)
            {
                bill = 50 * 0.50 + (consumed - 50) * 0.75;
            }
            else if (consumed <= 250)
            {
                bill = 50 * 0.50 + 100 * 0.75 + (consumed - 150) * 1.20;
            }
            else
            {
                bill = 50 * 0.50 + 100 * 0.75 + 100 * 1.20 + (consumed - 250) * 1.50;
            }
            netbill = bill + (bill * 20 / 100);
            Console.WriteLine("Net electricity bill is {0}$. ", netbill);
            Console.ReadKey();
        }
    }
}
