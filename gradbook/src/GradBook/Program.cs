using System;
using System.Collections.Generic;

namespace GradBook
{

    class Program
    {
        static void Main(string[] args) //main is a method- in the () is the paramertes, arg is the name
        {

            var book = new InMemoryBook("eben's Grade book");
            book.GradeAdded += OneGradeAdded;
            EnterGrades(book);


            //new class placed in file Book.cs
            // book.AddGrade(89.0);
            // book.AddGrade(90.5);
            // book.AddGrade(8); // the addGrade is from the class Book.cs
            var statsResult = book.GetStats();

            System.Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"the lowest grade is {statsResult.low}");
            Console.WriteLine($"the highest grade is {statsResult.High}");
            Console.WriteLine($"the Average grade is {statsResult.Average}");
            Console.WriteLine($"the letter is {statsResult.Letter:N1}");



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

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine(); //this will read the user input

                if (input == "q")
                {
                    break;
                }
                // with this try- this will use the input if it is right will carry on in the program
                //if not- the catch will tell the user the issue and carry on with the program without crashing the 
                // the program.
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (Exception ex) // this will put an error out to the user
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                    //this block will always run even if there was an exaption or not- once everything ran,
                    //this will then run after-
                }
            }
        }

        static void OneGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A greade was added");
        }

    }
}
