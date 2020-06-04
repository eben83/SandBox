﻿using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class Person
    {
        //Fields
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();
        
        //methods
        public void WriteToConsole ()
        {
            WriteLine($"{Name} was born on a {DateOfBirth: dddd}");
        }
        
        //static methods to "Multiply"
        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };
            
            p1.Children.Add(baby);
            p2.Children.Add(baby);

            return baby;
        }
        
        //instance method to "multiply"
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }
        
    }
}
