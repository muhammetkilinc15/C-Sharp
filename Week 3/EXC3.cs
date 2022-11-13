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
            int age, symptoms, test, cov19History, point = 0;
            Console.WriteLine("Select your age interval \n1) 18-40\n2) 40-65\n3) 65+ ");
            Console.Write("Your choice: ");
            age = int.Parse(Console.ReadLine());
            switch (age)
            {
                case 1:
                    point = 5;
                    break;
                case 2:
                    point = 15;
                    break;
                case 3:
                    point = 25;
                    break;
                default:
                    Console.WriteLine("Please enter valid number");
                    break;
            }
            Console.WriteLine("Have you experienced COV19 Symptoms?\n1) Yes\n2) No");
            Console.Write("Your choice: ");
            symptoms = int.Parse(Console.ReadLine());
            switch (symptoms)
            {
                case 1:
                    point += 25;
                    break;
                case 2:
                    point += 0;
                    break;

                default:
                    Console.WriteLine("Please enter valid number");
                    break;
            }
            Console.WriteLine("What is your COV19 test result?\n1) Positive\n2) Negative");
            Console.Write("Your choice: ");
            test = int.Parse(Console.ReadLine());
            switch (test)
            {
                case 1:
                    point += 25;
                    break;
                case 2:
                    point += 0;
                    break;
                default:
                    Console.WriteLine("Please enter valid number");
                    break;
            }
            Console.WriteLine("Have you been infected with COV19 before?\n1) Yes\n2) No");
            Console.Write("Your choice: ");
            cov19History = int.Parse(Console.ReadLine());
            switch (cov19History)
            {
                case 1:
                    point += 0;
                    break;
                case 2:
                    point += 25;
                    break;

                default:
                    Console.WriteLine("Please enter valid number");
                    break;
            }
            Console.WriteLine("Total score of the assessment is: {0}", point);
            if (point > 0 && point <= 25)
            {
                Console.WriteLine("Patient should rest at home.");
            }
            else if (point > 25 && point <= 50)
            {
                Console.WriteLine("Patient can rest at home with medicine.");
            }
            else if (point > 50 && point <= 75)
            {
                Console.WriteLine("Patient should be controlled under the doctor.");
            }
            else
            {
                Console.WriteLine("Patient should be intubated immediately");
            }
            Console.ReadKey();
        }
    }
}
