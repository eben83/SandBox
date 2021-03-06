using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
            
            BankAccount.InterestRate = 0.012M;
            
            
            

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
            
            //this is using the const
            WriteLine($"{bob.Name} is a {Person.Species}");
            
            //using the read- only
            WriteLine($"{bob.Name} was born on {bob.HomePlanet}");
            
            // methods that perform actions or return things
            bob.WriteToConsole();
            WriteLine(bob.GetOrigin());

            //tuples
            (string, int) fruit = bob.getFruit();
            WriteLine($"{fruit.Item1}, {fruit.Item2} are there");

            
            //named tuple- 
            var fruitNamed = bob.getNameedFruit();
            WriteLine($"there are {fruitNamed.Number} {fruitNamed.Name}'s");
            
            //tuple name inference
            var thing1 = ("Neville", 4);
            WriteLine($"{thing1.Item1} has {thing1.Item2} chidren");

            var thing2 = (bob.Name, bob.Children.Count);
            WriteLine($"{thing2.Name} has {thing2.Count} children");
            
            //deconstruction of tuple
            (string fruitName, int fruitNumber) = bob.getFruit();
            WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");
            
            //parameters into methods
            WriteLine(bob.SayHello());
            WriteLine(bob.SayHello("Dom"));
            
            //optional parameters
            WriteLine(bob.OptionalParameters());
            //passing other parameters
            WriteLine(bob.OptionalParameters("Jump", 2));
            //optional with naming parameters
            WriteLine(bob.OptionalParameters(number:52.6, command:"hide"));
            //skip parameters
            WriteLine(bob.OptionalParameters("poke", active: false));
            
            
            // passing parameter in and out
            int a = 10;
            int b = 20;
            int c = 30;// this will always be replace as its an out refrence parameter
            int d = 10;
            int e = 20;
            
            WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            bob.PassingParameters(a, ref b, out c);
            WriteLine($"After: a= {a}, b = {b}, c = {c}");
            
            WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet");
            bob.PassingParameters(d, ref e, out int f);
            WriteLine($"After: e = {d}, e = {e}, f = {f}");
            
            
            // new short hand to initialize the object.
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
            
            
            
            
            var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs. Jones";
            jonesAccount.Balance = 2400;
            
            WriteLine(format:
                "{0} earned {1:C} interest",
                arg0: jonesAccount.AccountName,
                arg1: jonesAccount.Balance * BankAccount.InterestRate);
            
            var gerrierAccount = new BankAccount
            {
                AccountName = "Ms. Gerrier",
                Balance = 98
            };
            
            WriteLine(format:
                "{0} earned {1:C} interest",
                arg0: gerrierAccount.AccountName,
                arg1: gerrierAccount.Balance * BankAccount.InterestRate);
            
            //constructors initialized
            var blankPerson = new Person();
            WriteLine(format:
                "{0} of {1} was created at {2: hh: mm: ss} on a {2: dddd}",
                arg0: blankPerson.Name,
                arg1: blankPerson.HomePlanet,
                arg2: blankPerson.Instantiated);
            
            // used the 2nd constructor to allow the initial values to be set
            var gunny = new Person("Gunny", "Mars");
            
            WriteLine(format:
                "{0} of {1} was created at {2: HH: mm: ss } on a {2: ddd}",
                arg0: gunny.Name,
                arg1: gunny.HomePlanet,
                arg2: gunny.Instantiated);
            
            
            //using properties
            var sam = new Person
            {
                Name = "Sam",
                DateOfBirth = new DateTime(1972, 1, 27)
            };
            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.Age);
         
            //properties with get and set methods
            sam.FavoriteIceCream = "Chocolate Fudge";
            WriteLine($"Sam's favorite ice-cream is {sam.FavoriteIceCream}");

            sam.FavoritePrimaryColor = "red";
            WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}");
            
            //indexers
            sam.Children.Add(new Person {Name = "Charlie"});
            sam.Children.Add(new Person {Name = "Ella"});
            
            WriteLine($"Sam's 1st child is {sam.Children[0].Name}");
            WriteLine($"Sam's 2nd child is {sam.Children[1].Name}");
            
            // WriteLine($"Sam's 1st child is {sam[0].Name}");
            // WriteLine($"Sam's 2nd child is {sam[1].Name}");

        }
    }
}
