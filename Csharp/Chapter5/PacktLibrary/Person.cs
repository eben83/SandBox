using System;
using static System.Console;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person: object
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
    }
}
