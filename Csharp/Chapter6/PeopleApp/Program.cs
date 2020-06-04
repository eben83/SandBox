using System;
using static System.Console;
using Packt.Shared;


namespace PeopleApp
{
    class Program
    {
        //delegate
        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person) sender;
            WriteLine($"{p.Name} is this angry {p.AngerLevel}");
        }
        
        static void Main(string[] args)
        {
            var harry = new Person {Name = "Harry"};
            var mary = new Person {Name = "Mary"};
            var jill = new Person {Name = "Jill"};
            
            //call instance method
            var baby1 = mary.ProcreateWith(harry);
            
            //call static method
            var baby2 = Person.Procreate(harry, jill);
            
            //call an operator
            var baby3 = harry * mary;
            
            WriteLine($"{harry.Name} has {harry.Children.Count} children");
            WriteLine($"{mary.Name} has {mary.Children.Count} children");
            WriteLine($"{jill.Name} has {jill.Children.Count} children");
            
            WriteLine(format:
                "{0}'s first child is named \"{1}\".",
                arg0: harry.Name,
                arg1: harry.Children[0].Name);
            WriteLine(format:
                "{0}'s second child is named \"{1}\".",
                arg0: harry.Name,
                arg1: harry.Children[1].Name);
            
            
            //calling the Factorial function
            WriteLine($"5! is {Person.Factorial(5)}");
            
            //assigning the method to the delegate
            harry.Shout = Harry_Shout;
            
            //calling the poke method
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();

        }
    }
}
