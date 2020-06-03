using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person: object
    {
        //fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
    }
}
