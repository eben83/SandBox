using System;
using static System.Console;

namespace Packt.Shared
{
    public class Employee: Person
    {
        
        //extending the class from the inherited class
        public string EmployeeCode { get; set; }
        public DateTime HiteDate { get; set; }

        public new void WriteToConsole()
        {
            WriteLine(format:
                "{0} was born on {1: dd/ MM/ yy} and hired on {2: dd/ MM/ yy}",
                arg0: Name,
                arg1: DateOfBirth,
                arg2: HiteDate);
        }

        public override string ToString()
        {
            return $"{Name}'s code is {EmployeeCode}";
        }
    }
}