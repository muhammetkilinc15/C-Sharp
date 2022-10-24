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
            int first = 1315;
            int second = 1654;
            int third = 2212;
            int fourth = 1941;

            int firstMinute = first % 100;
            int secondMinute = second % 100;
            int thirdMinute = third % 100;
            int fourthMinute = fourth % 100;

            int firstTime = ((first / 100) * 60) + firstMinute;
            int secondTime = ((second / 100) * 60) + secondMinute;
            int thirdTime = ((third / 100) * 60) + thirdMinute;
            int fourthTime = ((fourth / 100) * 60) + fourthMinute;

            int firstProximate = fourthTime - firstTime;
            int secondProximate = fourthTime - secondTime;
            int thirdProximate = fourthTime - thirdTime;

            int check;
            check = firstProximate < secondProximate ? first : second;
            check = secondProximate < thirdProximate ? second : third;

            Console.WriteLine(check + " is closer to " + fourth);



        }
    }
}
