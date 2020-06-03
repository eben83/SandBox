using System;
using static System.Console;
using Packt.Shared;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // this class is the Person class imported to this app
            var bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 22);
            bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            
            //storing multiple values using an enum type
            bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon |
                             WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

            WriteLine(format:
                "{0} was born on {1: dddd, d MMMM yyyy}",
                arg0: bob.Name,
                arg1: bob.DateOfBirth);
            
            WriteLine(format:
                "{0}'s favorite wonder is {1}. It's integer value is {2}",
                arg0: bob.Name,
                arg1: bob.FavoriteAncientWonder,
                arg2: (int)bob.FavoriteAncientWonder);
            
            WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
            
            bob.Children.Add(new Person{Name = "Alfred"});
            bob.Children.Add(new Person{Name = "Zoe"});
            
            WriteLine($"{bob.Name} has {bob.Children.Count} children");
            for (int child = 0; child < bob.Children.Count; child++)
            {
                WriteLine($"{bob.Children[child].Name}");
            }

            //not working correctly
            foreach (var child in bob.Children)
            {
                WriteLine($"{child.ToString()}");
            }
            
            
            
            
            
            var alice = new Person
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3,7)
            };
            
            WriteLine(format:
                "{0} was born on {1: dd MMM yy}",
                arg0: alice.Name,
                arg1: alice.DateOfBirth
                );
        }
    }
}
