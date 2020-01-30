using System;
using System.Collections.Generic;

namespace GradBook
{
    class Program
    {
        static void Main(string[] args) //main is a method- in the () is the paramertes, arg is the name
        {
            var x = 34.1;
            var y = 22.2;
            var result = x + y;
            Console.WriteLine(result);

            //creating number arrays- 
            var numbers = new [] {12.7, 14.5, 22.2};
            // list of double- add the above using statment Cmd + . will open the window to add
            var grades = new List<double>(){12.7, 14.5, 22.2, 55.1};
            grades.Add(89.31);
            
            //another way- var numbers = new double[3]; 
            //this will hold an array of length of 3, won't be
            //able to add any more to that, the one above allows as many numbers with the initializer
            // which is between the {} 
            
            //adding up the array
            //var ArrayResult = numbers[0];
            //ArrayResult += numbers[1];
            //ArrayResult += numbers[2];
            //Console.WriteLine(ArrayResult);

            //for Each statment- 
            var resultForEach = 0.0;
            foreach(var number in grades) 
            {
                resultForEach += number;
                
            }
            Console.WriteLine(resultForEach);
            var average = resultForEach / grades.Count;
            System.Console.WriteLine($" the average for the grade is {average:N1}"); // the :N3 will give you the format to 3 decimal place



            if (args.Length > 0) 
            {
            Console.WriteLine("Hello " + args[0] + "!"); //concat strings, adding the args sub zero from the array

            Console.WriteLine($"Hello, {args[0]} !"); //string interpelation

            }
            else 
            {
                Console.WriteLine("Hello");
            }
        }
    }
}
