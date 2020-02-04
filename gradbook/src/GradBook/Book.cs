using System;
using System.Collections.Generic;
using System.IO;

namespace GradBook
{

    public delegate void GradeAddedDelegate(object sender, EventArgs args); // event

    public class NameObject // inheritance.
    {
        public NameObject(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            set;
        }
    }

    public interface IBook
    {
        void AddGrade(double grade);
        stats GetStats();
        string Name {get; }
        event GradeAddedDelegate GradeAdded;
    }

    public abstract class Book : NameObject, IBook
    {
        public Book(string name) : base(name)
        {
        }

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public abstract stats GetStats();
    }


    public class InMemoryBook: Book
    {
        public InMemoryBook(string name) : base(name) 
        // this is the initialiser
                                // inside the () is a perameter 
        {
            grades = new List<double> ();
            Name = name;   // this key work help with var's with the similar names-
        }

        public void AddGrade(char Letter) //switch statemetns
        {
            switch(Letter){
                case 'A': 
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }

        public override void AddGrade(double grade) // public instnce of the method
        {

            if(grade == 90.90) // this is the equal too
            {
                
            }
            if(grade <= 100 && grade >= 0) // boolian if statement with AND
            {
                grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else 
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
                // throw exeption- this is an error handle..
            }
        }

        public class DiskBook : Book
        {
            public DiskBook(string name) : base(name)
            {
            }

            public override event GradeAddedDelegate GradeAdded;

            public override void AddGrade(double grade)
            {
                var writer = File.AppendText($"{Name}.txt"); //opens file
                writer.WriteLine(grade); //writes to file
                writer.Close(); // closes file
            }

            public override stats GetStats()
            {
                throw new NotImplementedException();
            }
        }

        public override event GradeAddedDelegate GradeAdded;

        public override stats GetStats()
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

            //switch statement using "case" and "when" key word
            switch(result.Average) 
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;

                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;

                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;

                default:
                    result.Letter = 'F';
                    break;
            }


            return result;


        }
        private List<double> grades;
        
       
    }
}