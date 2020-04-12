using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;

namespace OneFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int EXIT_MENU_CHOICE = 4;

            int menuChoice = 0;
            var animalsList = new List<Animal>();

            while (menuChoice != EXIT_MENU_CHOICE)
            {
                switch (menuChoice)
                {
                    case 0:
                        //Clear the console and show the welcome message
                        Console.Clear();
                        Console.WriteLine("Welcome, This is mt one page Animal App, I hope you will enjoy it");
                        Console.WriteLine();

                        //Show the main menu
                        Console.WriteLine();
                        Console.WriteLine("1. Add animal");
                        Console.WriteLine("2. Interact with animal");
                        Console.WriteLine("3. Interact with all animals");
                        Console.WriteLine("4. Exit");
                        Console.WriteLine();

                        var isMainMenuChoiceValid = false;
                        while (!isMainMenuChoiceValid)
                        {
                            Console.WriteLine("Please, make a selection, to carry on.");

                            if (!int.TryParse(Console.ReadLine(), out menuChoice))
                            {
                                Console.WriteLine("Sorry your choice is incorrect");
                                Console.WriteLine("Please, try make another choice.");
                                Console.ReadLine();

                                //Clear the console and show the welcome message
                                Console.Clear();
                                Console.WriteLine("Welcome, This is mt one page Animal App, I hope you will enjoy it");
                                Console.WriteLine();

                                //Show the main menu
                                Console.WriteLine();
                                Console.WriteLine("1. Add animal");
                                Console.WriteLine("2. Interact with animal");
                                Console.WriteLine("3. Interact with all animals");
                                Console.WriteLine("4. Exit");
                                Console.WriteLine();
                            }
                            else
                            {
                                isMainMenuChoiceValid = true;
                            }
                        }

                        break;

                    case 1:
                        //Clear the console and show the welcome message
                        Console.Clear();
                        Console.WriteLine("Welcome, This is mt one page Animal App, I hope you will enjoy it");
                        Console.WriteLine();

                        //Show the available animal types menu
                        Console.WriteLine("The following animals are available:");
                        Console.WriteLine("1. Dog");
                        Console.WriteLine("2. Cat");
                        Console.WriteLine("3. Elephant");
                        Console.WriteLine("4. Fish");
                        Console.WriteLine("5. Ostrich");
                        Console.WriteLine();

                        var animalMenuOption = 0;
                        var isAnimalMenuChoiceValid = false;
                        while (!isAnimalMenuChoiceValid)
                        {
                            Console.WriteLine("Which animal would you like to add?");

                            if (!int.TryParse(Console.ReadLine(), out animalMenuOption))
                            {
                                Console.WriteLine("Sorry your choice is incorrect");
                                Console.WriteLine("Please, try make another choice.");
                                Console.ReadLine();

                                //Clear the console and show the welcome message
                                Console.Clear();
                                Console.WriteLine("Welcome, This is mt one page Animal App, I hope you will enjoy it");
                                Console.WriteLine();

                                //Show the available animal types menu
                                Console.WriteLine("The following animals are available:");
                                Console.WriteLine("1. Dog");
                                Console.WriteLine("2. Cat");
                                Console.WriteLine("3. Elephant");
                                Console.WriteLine("4. Fish");
                                Console.WriteLine("5. Ostrich");
                                Console.WriteLine();
                            }
                            else
                            {
                                isAnimalMenuChoiceValid = true;
                            }
                        }

                        string animalType = "";
                        switch (animalMenuOption)
                        {
                            case 1:
                                animalType = "Dog";
                                break;
                            case 2:
                                animalType = "Cat";
                                break;
                            case 3:
                                animalType = "Elephant";
                                break;
                            case 4:
                                animalType = "Fish";
                                break;
                            case 5:
                                animalType = "Ostrich";
                                break;
                            default: throw new Exception("Invalid choice, please try again.");
                        }

                        Console.WriteLine($"What name would you like to give your new {animalType}");
                        string animalName = Console.ReadLine();

                        Console.WriteLine($"Brilliant, Your {animalType} now has the name of {animalName}- " +
                                          $"Congratulations on the new member to the family...");
                        Console.WriteLine("Press Enter to carry on.");
                        Console.ReadLine();

                        var animal = new Animal(animalName);
                        animal.Type = animalType;
                        animalsList.Add(animal);

                        //reset menu choice so we can display the main menu again
                        menuChoice = 0;
                        break;

                    case 2:
                        //Clear the console and show the welcome message
                        Console.Clear();
                        Console.WriteLine("Welcome, This is mt one page Animal App, I hope you will enjoy it");
                        Console.WriteLine();

                        Console.WriteLine("The following animals are what you've added and are able to interact with them:");
                        Console.WriteLine("(To add more, follow the Add Animal menu option one)");
                        
                        for (int i = 0; i < animalsList.Count; i++)
                        {
                            Console.WriteLine($"{i}. {animalsList[i].Identification}");
                        }

                        var actualAnimalsMenuOption = 0;
                        var isActualAnimalMenuChoiceValid = false;
                        while (!isActualAnimalMenuChoiceValid)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Which of your animals would you like to interact with?");

                            if (!int.TryParse(Console.ReadLine(), out actualAnimalsMenuOption))
                            {
                                Console.WriteLine("Sorry your choice is incorrect");
                                Console.WriteLine("Please, try make another choice.");
                                Console.ReadLine();

                                //Clear the console and show the welcome message
                                Console.Clear();
                                Console.WriteLine("Welcome, This is mt one page Animal App, I hope you will enjoy it");
                                Console.WriteLine();

                                Console.WriteLine("These are your animals that you are able to interact with:");
                                Console.WriteLine("(To add more, follow the Add Animal menu option one)");
                        
                                for (int i = 0; i < animalsList.Count; i++)
                                {
                                    Console.WriteLine($"{i}. {animalsList[i].Identification}");
                                }
                            }
                            else
                            {
                                isActualAnimalMenuChoiceValid = true;
                            }
                        }

                        Animal selectedAnimal = animalsList[actualAnimalsMenuOption];

                        //Show the available action that animals can perform
                        Console.WriteLine($"Your {selectedAnimal.Type} can perform the following actions:");
                        Console.WriteLine("1. Eat");
                        Console.WriteLine("2. Sleep");
                        Console.WriteLine("3. Run");
                        Console.WriteLine("4. Fly");

                        //TODO:Implement the rest of the method here
                        var animalActionOption = 0;
                        var isActualAnimalActionOption = false;

                        while (! isActualAnimalActionOption)
                        {
                            if (!int.TryParse(Console.ReadLine(), out animalActionOption))
                            {
                                Console.WriteLine("Sorry your choice is incorrect");
                                Console.WriteLine("Please, try make another choice.");
                                menuChoice = 0;
                                Console.ReadLine();
                            
                                //clear the console
                                Console.Clear();
                                Console.WriteLine("Welcome, This is mt one page Animal App, I hope you will enjoy it");
                            }
                            else
                            {
                                isActualAnimalActionOption = true;
                            }
                        }
                        switch(animalActionOption)
                        {
                            case 1:
                                selectedAnimal.Eat();
                                break;
                            case 2:
                                selectedAnimal.Sleep();
                                break;
                            case 3:
                                selectedAnimal.Run();
                                break;
                            case 4:
                                selectedAnimal.Fly();
                                break;
                            default:
                                throw new Exception("Sorry, something went wrong there, " +
                                                    "please, make another choice.");
                        }

                        Console.ReadLine();

                        //reset menu choice so we can display the main menu again
                        menuChoice = 0;
                        break;

                    case 3:

                        var allAnimalActionOption = 0;
                        //TODO: Implement the rest of the method here
                        //Clear screen, and display the welcome message
                        Console.Clear();
                        Console.WriteLine("Welcome, This is mt one page Animal App, I hope you will enjoy it");
                        Console.WriteLine();
                        Console.WriteLine("These following animals will perform the action to decide," +
                                          "all at once.");
                        
                        //show the list of animals again.
                        for (int i = 0; i < animalsList.Count; i++)
                        {
                            Console.WriteLine($" {animalsList[i].Identification}");
                        }
                        //show the list of actions
                        Console.WriteLine($"What action would yo like all your animals to do?");
                        Console.WriteLine("1. Eat");
                        Console.WriteLine("2. Sleep");
                        Console.WriteLine("3. Run");
                        Console.WriteLine("4. Fly");
                        //get action from user

                        if (!int.TryParse(Console.ReadLine(), out allAnimalActionOption))
                        {
                            Console.WriteLine("Sorry your choice is incorrect");
                            Console.WriteLine("Please, try make another choice.");
                            menuChoice = 0;
                            Console.ReadLine();
                            
                            //clear the console
                            Console.Clear();
                            Console.WriteLine("Welcome, This is mt one page Animal App, I hope you will enjoy it");
                        }
                        else
                        {
                            isActualAnimalActionOption = true;
                        }
                        
                        //loop all animals though the actions.

                        foreach (var pet in animalsList)
                        {
                            switch (allAnimalActionOption)
                            {
                                case 1:
                                    Console.WriteLine(pet.Identification);
                                    pet.Eat();
                                    break;
                                case 2:
                                    Console.WriteLine(pet.Identification);
                                    pet.Fly();
                                    break;
                                case 3:
                                    Console.WriteLine(pet.Identification);
                                    pet.Run();
                                    break;
                                case 4:
                                    Console.WriteLine(pet.Identification);
                                    pet.Sleep();
                                    break;
                                default:
                                    throw new Exception("Wrong Choice, Please TRY again...");
                            }
                        }

                        Console.ReadLine();

                        //reset menu choice so we can display the main menu again
                        menuChoice = 0;
                        break;
                }
            }
        }
    }
    
    public class Animal
    {
        public string Type { get; set; }
        public string Name { get; set; }

        public string Identification
        {
            get { return $"{Name} the {Type}"; }
            
        }
        
        public Animal(string name)
        {    //constructor
            Name = name;
        }

        public void Run()
        {
            Console.WriteLine("doof, doof, doof");
            Console.WriteLine("Look at him go!");
            Console.WriteLine("Feeling the earth moving!!");
            Console.WriteLine($"{Type} stops Running. He looks quite Hungry");
            Console.WriteLine($"{Type} is running....");
            Console.WriteLine("and tired now.");
            Console.WriteLine();
        }

        public void Eat()
        {
            Console.WriteLine($"{Type} is eating...");
            Console.WriteLine("munch, munch, munch");
            Console.WriteLine("Look at all that food go down!!!");
            Console.WriteLine("Burp!!"); 
            Console.WriteLine();
        }

        public void Sleep()
        {
            Console.WriteLine($"{Type} is sleeping...");
            Console.WriteLine("ZZzzZZZzzzZZz");
            Console.WriteLine("how loud can he snore!!!");
            Console.WriteLine("Cats can sleep all day");
        }

        public void Fly()
        {
            Console.WriteLine("Is it a bird?!");
            Console.WriteLine("Is it a plane?!");
            Console.WriteLine("it's a Flamingo!!");
        }
    }
}