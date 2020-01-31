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

            if(grade == 90.90) // this is the equal too
            {
                
            }
            if(grade <= 100 && grade >= 0) // boolian if statement
            {
                grades.Add(grade);
            }
            else 
            {
                System.Console.WriteLine("Invalid Value");
            }
        }
        public stats GetStats()
        {
            var result = new stats();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.low = double.MaxValue;

            //jumping statements

            //for loop
            for(var index2 = 0; index2 < grades.Count; index2 += 1)
            {
                result.low = Math.Min(grades[index2], result.low);
                result.High = Math.Max(grades[index2], result.High);
                result.Average += grades[index2];                
            }

            result.Average /= grades.Count;
            return result;

            // While Loop
            // while(index < grades.Count) --this is a while loop the loop will only
            //                             -- run if the while statement is true.
            // {
            //     result.low = Math.Min(grades[index], result.low);
            //     result.High = Math.Max(grades[index], result.High);
            //     result.Average += grades[index];
            //     index += 1;
                
            // } ;
            //result.Average /= grades.Count;

            //do while loop-- will run at least once

            var index = 0;

            do 
            {
                result.low = Math.Min(grades[index], result.low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
                index += 1;
                
            } while(index < grades.Count);
            
            result.Average /= grades.Count;
            return result;

            //for Each statment- 

            // foreach(var grade in grades) 
            // {
            //     result.low = Math.Min(grade, result.low);
            //     result.High = Math.Max(grade, result.High);
            //     result.Average += grade;
                
            // }
            
            // result.Average /= grades.Count;

            return result;
        }


        
        // public void highGrade(double grade) {
        //     grade.highGrade(grade);
        // }

        private List<double> grades;
        public string Name;
    }
}