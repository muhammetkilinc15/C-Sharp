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

            int temperature, wind, humidity, dif , possibilityOfTheRain;

            Console.WriteLine("Enter temperature value : ");
            temperature = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter wind value : ");
            wind = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter humidity value : ");
            humidity = int.Parse(Console.ReadLine());

            dif = temperature - wind;
            possibilityOfTheRain = (dif * dif) - humidity;

            String condition;
            condition = possibilityOfTheRain >= 575 ? "there will not be rain" : "there will be rain ";
            Console.WriteLine("The result is {0} and {1} " , possibilityOfTheRain, condition);

            Console.ReadKey();
            




        }
    }
}
