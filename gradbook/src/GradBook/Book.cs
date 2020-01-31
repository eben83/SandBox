using System;
using System.Collections.Generic;

namespace GradBook
{
    class Book
    {
        public Book(string name) // this is the initialiser 
        {
            grades = new List<double> ();
            this.name = name;   // this key work help with var's with the similar names-
        }

        public void AddGrade(double grade) // public instnce of the method
        {
            grades.Add(grade);
        }
        public void showStats()
        {
            //for Each statment- 
            var resultForEach = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var number in grades) 
            {
                if (number > highGrade) { //this finds the highest number
                    highGrade = number;
                }
                if (number <= lowGrade) { //finds the lowest number
                    lowGrade = number;
                }

                resultForEach += number;
                
            }
            Console.WriteLine(resultForEach);
            var average = resultForEach / grades.Count;
            Console.WriteLine($" the average for the grade is {average:N1}"); 
            Console.WriteLine($" this is the highest grade {highGrade}");
            Console.WriteLine($" this is the lowest Grade {lowGrade}");
            // the :N3 will give you the format to 3 decimal place
        }


        
        // public void highGrade(double grade) {
        //     grade.highGrade(grade);
        // }

        private List<double> grades;
        private string name;
    }
}