using System;

namespace Calculator
{
    class program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int result;
            string answer;

            Console.WriteLine("Hello Welcome to the Calculator Program:");
            Console.WriteLine("Please enter your First Number");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Eneter your Second Number");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please eneter  a for addition, s for subtraction, m for multiplication or d for division");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1/num2;
            }

            Console.WriteLine("The result is " + result);
            Console.WriteLine("Thank you for using teh calculator app");

            Console.ReadLine();

        }
    }
}