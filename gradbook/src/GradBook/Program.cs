using System;

namespace GradBook
{
    class Program
    {
        static void Main(string[] args) //main is a method- in the () is the paramertes, arg is the name
        {
            if (args.Length > 0) 
            {

            Console.WriteLine("Hello " + args[0] + "!"); //concat strings, adding the args sub zero from the array

            Console.WriteLine($"Hello, {args[0]} !"); //string interpelation
            }
            else {
                Console.WriteLine("Hello");
            }
        }
    }
}
