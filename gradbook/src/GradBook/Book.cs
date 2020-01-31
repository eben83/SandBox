using System;
using System.Collections.Generic;

namespace GradBook
{
    public class Book
    {
        public Book(string name) // this is the initialiser
                                // inside the () is a perameter 
        {
            grades = new List<double> ();
            Name = name;   // this key work help with var's with the similar names-
        }

        public void AddGrade(double grade) // public instnce of the method
        {
            grades.Add(grade);
        }
        public stats GetStats()
        {
            var result = new stats();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.low = double.MaxValue;


            //for Each statment- 

            foreach(var grade in grades) 
            {
                result.low = Math.Min(grade, result.low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
                
            }
            
            result.Average /= grades.Count;

            return result;
        }


        
        // public void highGrade(double grade) {
        //     grade.highGrade(grade);
        // }

        private List<double> grades;
        public string Name;
    }
}