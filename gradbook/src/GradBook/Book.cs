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

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        private List<double> grades;
        private string name;
    }
}