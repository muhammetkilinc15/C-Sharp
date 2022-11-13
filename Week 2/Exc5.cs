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

            int siteOneX, siteOneY, siteTwoX, siteTwoY, distanceOne, distanceTwo, difOneX, difOneY, difTwoX, difTwoY;
            int schoolX = -7, schoolY = 5;
            Console.WriteLine("Enter x of Site 1: ");
            siteOneX = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y of Site 1: ");
            siteOneY = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter x of Site 2: ");
            siteTwoX = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y of Site 2: ");
            siteTwoY = int.Parse(Console.ReadLine());


            difOneX = siteOneX - schoolX;
            difOneY = siteOneY - schoolY;
            distanceOne = (difOneX * difOneX) + (difOneY * difOneY);

            difTwoX = siteTwoX - schoolX;
            difTwoY = siteTwoY - schoolY;
            distanceTwo = (difTwoX * difTwoX) + (difTwoY * difTwoY);

            Console.WriteLine("Distance from site 1 to school: {0} \nDistance from site 2 to school: {1} ", distanceOne,distanceTwo);
            
            string conditionOne, conditionTwo;

            conditionOne = distanceOne < 120 ? "not allowed" : "allowed ";
            conditionTwo = distanceTwo < 120 ? "not allowed" : "allowed ";

            Console.WriteLine("Construction site 1 is {0} \nConstruction site 2 is {1} ", conditionOne,conditionTwo);
           







        }
    }
}
