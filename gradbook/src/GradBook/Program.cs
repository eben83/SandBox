using System;
using System.Collections.Generic;

namespace GradBook
{

    class Program
    {
        static void Main(string[] args) //main is a method- in the () is the paramertes, arg is the name
        {

            var book = new Book("eben's Grade book");
             //new class placed in file Book.cs
            book.AddGrade(89.0);
            book.AddGrade(90.5);
            book.AddGrade(8); // the addGrade is from the class Book.cs
            book.showStats();

            //creating number arrays- 
            //var numbers = new [] {12.7, 14.5, 22.2};
            // list of double- add the above using statment Cmd + . will open the window to add
            //var grades = new List<double>(){12.7, 14.5, 22.2, 55.1};
            //grades.Add(89.31);
            
            


            //var x = 34.1;
           // var y = 22.2;
           // var result = x + y;
           // Console.WriteLine(result);


           //another way- var numbers = new double[3]; 
            //this will hold an array of length of 3, won't be
            //able to add any more to that, the one above allows as many numbers with the initializer
            // which is between the {} 
            
            //adding up the array
            //var ArrayResult = numbers[0];
            //ArrayResult += numbers[1];
            //ArrayResult += numbers[2];
            //Console.WriteLine(ArrayResult);


        }
    }
}
