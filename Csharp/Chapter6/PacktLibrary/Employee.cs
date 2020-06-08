using System;
using static System.Console;

namespace Packt.Shared
{
    public class Employee: Person
    {
        
        //extending the class from the inherited class
        public string EmployeeCode { get; set; }
        public DateTime HiteDate { get; set; }
    }
}