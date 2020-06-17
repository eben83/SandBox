using System;
using static System.Console;

namespace Factorial
{
    class Program
    {
        static int Factorial(int number)
        {
            if (number < 1)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        static void RunFactorial()
        {
            bool isNumber;
            do
            {
                Write("Enter a number:    ");

                isNumber = int.TryParse(
                    ReadLine(), out int number);

                if (isNumber)
                {
                    WriteLine($"{number}! = {Factorial(number)}");
                }
                else
                {
                    WriteLine("you did not enter a valid number");
                }
            } while (isNumber);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RunFactorial();
        }
    }
}