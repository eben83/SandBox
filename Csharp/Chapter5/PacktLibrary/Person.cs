using System;
using static System.Console;
using System.Collections.Generic;

namespace Packt.Shared
{
    public partial class Person : object
    {
        //fields- use the instance to access
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();

        //constant- a field that will never change- use the class to access
        public const string Species = "Homo Sapien";

        //read-only fields- use the instance to access
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        //constructors- when a field need to be initialized at runtime
        public Person()
        {
            //set default values for fields
            //including read-only fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }


        // second constructor- this allows to set initial values
        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        //method
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth: dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born {HomePlanet}";
        }

        //tuples
        public (string, int) getFruit()
        {
            return ("Apples", 5);
        }

        //naming the tuple items
        public (string Name, int Number ) getNameedFruit()
        {
            return (Name: "Banana", Number: 5);
        }

        // passing parameters into methods
        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }

        public string SayHello(string name)
        {
            return $"{Name} says 'hello {name}!'";
        }

        //optional parameters
        public string OptionalParameters(
            string command = "Run!",
            double number = 0.0,
            bool active = true)
        {
            return string.Format(
                format: "Command is {0}, number is {1}, active is {2}", arg0: command, arg1: number, arg2: active);
        }
        
        //passing parameters in and out
        public void PassingParameters(int x, ref int y, out int z)
        {
            //out parameters cannot have defaults
            //& must be initialised inside the method
            z = 99;
            
            //increment each parameter
            x++;
            y++;
            z++;
        }
    }
}
