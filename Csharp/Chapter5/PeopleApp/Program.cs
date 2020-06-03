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
            
            

            //not working correctly
            // foreach (var child in bob.Children)
            // {
            //     WriteLine($"{child.ToString()}");
            // }
            //
            
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
        }
    }
}
