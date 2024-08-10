using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int result;
            string answer;
            Console.WriteLine("Hello! Welcome to calculator");
            Console.WriteLine("Please enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pleasem enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a third number");
            num3 = Convert.ToInt32(Console.ReadLine()); ;

            Console.WriteLine("What type of operation do you like to do?");
            Console.WriteLine("Please enter a for addition ,s for substraction,m for multiplication and d for divison");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2 + num3;
            }
            else if (answer == "s")
            {
                result = num1 - num2 - num3;
            }
            else if (answer == "m")
            {
                result = num1 * num2 * num3;
            }
            else
            {
                result = num1 / num2 / num3;
            }

            Console.WriteLine("The solution is " +result);
            Console.WriteLine("Thankyou for visiting our calculator");
            Console.ReadKey();

        }
    }
}
