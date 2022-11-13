using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EXC6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 500, withdrawn, remainingMoney;

            Console.Write("Enter the amount for withdraw: ");
            withdrawn = int.Parse(Console.ReadLine());

            remainingMoney = balance - withdrawn;   // 500 - 300
            int remainderOne = balance - withdrawn; // 500 - 700
            int remainderTwo = balance - 1000;      // 500 - 1000

            double charged1 = remainderOne * 1.7 * (-1);
            double charged2 = remainderTwo * 1.7 * (-1);

            String str1, str2, str3;
            str1 = "Amount in the bank account :";
            str2 = "You are charged with :";
            str3 = "You can withdraw 1000$ at most!"; 

            string result;

            result = balance > withdrawn ? (str1 + remainderOne + "$") :
                withdrawn > 1000 ? ((str3) + "\n" + (str1 + remainderTwo +"$") + "\n" + (str2 + charged2 + "$")) :
                ((str1 + remainderOne + "$") + "\n" + (str2 + charged1 +"$"));

            Console.WriteLine("{0}",result);

            Console.ReadKey();



















        }
    }
}
