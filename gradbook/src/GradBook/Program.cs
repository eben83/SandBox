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



            var statsResult = book.GetStats();

            System.Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"the lowest grade is {statsResult.low}");
            Console.WriteLine($"the highest grade is {statsResult.High}");
            Console.WriteLine($"the Average grade is {statsResult.Average}");
            Console.WriteLine($"the letter is {statsResult.Letter:N1}");




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
