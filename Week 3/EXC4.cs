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

            int sideOne, sideTwo, sideThree, angleOne, angleTwo, angleThree;
            Console.Write("Enter the first side : ");
            sideOne = int.Parse(Console.ReadLine());
            Console.Write("Enter the second side : ");
            sideTwo = int.Parse(Console.ReadLine());
            Console.Write("Enter the third side : ");
            sideThree = int.Parse(Console.ReadLine());

            Console.Write("Enter the first angle : ");
            angleOne = int.Parse(Console.ReadLine());
            Console.Write("Enter the second angle : ");
            angleTwo = int.Parse(Console.ReadLine());
            Console.Write("Enter the third angle : ");
            angleThree = int.Parse(Console.ReadLine());

            if (((sideOne + sideTwo) > sideThree) && ((sideOne + sideThree) > sideTwo) && ((sideTwo + sideThree) > sideOne))
            {
                Console.WriteLine("Sides are meeting the conditions.");
                if (angleOne > 0 && angleTwo > 0 && angleThree > 0 && (angleOne + angleTwo + angleThree == 180))
                {
                    Console.WriteLine("Angles are meeting the conditions.");
                    if (sideOne == sideTwo && sideTwo == sideThree)
                    {
                        if (angleOne == angleTwo && angleTwo == angleThree)
                        {
                            Console.WriteLine("Equilateral triangle");
                        }
                    }
                    else if (sideOne == sideTwo || sideOne == sideThree || sideTwo == sideThree)
                    {
                        if (angleOne == angleTwo || angleOne == angleThree || angleTwo == angleThree)
                        {
                            Console.WriteLine("İsosceles  triangle");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Scalane triangle");
                    }
                }
                else
                {
                    Console.WriteLine("Angles are not meeting the conditions.");
                }
            }
            else
            {
                Console.WriteLine("Sides are not  meeting the conditions");              
            }
            Console.ReadKey();
        }
    }
}
