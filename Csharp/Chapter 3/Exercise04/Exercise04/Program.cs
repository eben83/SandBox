using System;
using static System.Console;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter a number between 0 and 255:");
            var firstNumber = ReadLine();
        
            WriteLine("Enter a number between 0 and 255:");
            var secondNumber = ReadLine();

            try
            {
                var numberOne = int.Parse(firstNumber);
                var numberTwo = int.Parse(secondNumber);
                var total = numberOne * numberTwo;
        
                WriteLine($"{total}");
            }
            catch (FormatException)
            {
                WriteLine("Please enter a number");
                throw;
            }
        }
    }
}