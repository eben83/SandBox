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
                // this will write to a file
                using (var writer = File.AppendText($"{Name}.txt")) //using statements- is a good way to work with 
                                                                    // writing to file and using ports- etc.
                {
                    writer.WriteLine(grade); //writes to file
                    if( GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                } //opens file
                
            }

            public override stats GetStats()
            {
                //this reads from a file
                var result = new stats();
                
                using(var reader = File.OpenText($"{Name}.txt"))
                {
                    var line = reader.ReadLine();
                    while(line != null)
                    {
                        var number = double.Parse(line);
                        result.Add(number);
                        line = reader.ReadLine();
                    }
                }

                return result;
            }
        }

        public override event GradeAddedDelegate GradeAdded;

        public override stats GetStats()
        {
            var result = new stats();
            

            //jumping statements
           
            //for loop
            for(var index = 0; index < grades.Count; index += 1)
            {
                result.Add(grades[index]);        
            }

            //switch statement using "case" and "when" key word
            


            return result;


        }
        private List<double> grades;
        
       
    }
}