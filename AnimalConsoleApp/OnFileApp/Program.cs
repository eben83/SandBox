using System;
using System.Collections.Generic;

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
                        Console.WriteLine("Welcome to my one page Animal App");
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
                            Console.WriteLine("What would you like to do?");

                            if (!int.TryParse(Console.ReadLine(), out menuChoice))
                            {
                                Console.WriteLine("Sorry your choice is incorrect");
                                Console.WriteLine("Please make another choice.");
                                Console.ReadLine();

                                //Clear the console and show the welcome message
                                Console.Clear();
                                Console.WriteLine("Welcome to my Animal App");
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
                        Console.WriteLine("Welcome to my one page Animal App");
                        Console.WriteLine();

                        //Show the available animal types menu
                        Console.WriteLine("The following animals are available:");
                        Console.WriteLine("1. Dog");
                        Console.WriteLine("2. Cat");
                        Console.WriteLine("3. Elephant");
                        Console.WriteLine("4. Fish");

                        var animalMenuOption = 0;
                        var isAnimalMenuChoiceValid = false;
                        while (!isAnimalMenuChoiceValid)
                        {
                            Console.WriteLine("Which animal would you like to add?");

                            if (!int.TryParse(Console.ReadLine(), out animalMenuOption))
                            {
                                Console.WriteLine("Sorry your choice is incorrect");
                                Console.WriteLine("Please make another choice.");
                                Console.ReadLine();

                                //Clear the console and show the welcome message
                                Console.Clear();
                                Console.WriteLine("Welcome to my one page Animal App");
                                Console.WriteLine();

                                //Show the available animal types menu
                                Console.WriteLine("The following animals are available:");
                                Console.WriteLine("1. Dog");
                                Console.WriteLine("2. Cat");
                                Console.WriteLine("3. Elephant");
                                Console.WriteLine("4. Fish");
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
                            default: throw new Exception("Invalid animal type.");
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
                        Console.WriteLine("Welcome to my one page Animal App");
                        Console.WriteLine();

                        Console.WriteLine("These are your animals that you can interact with:");
                        Console.WriteLine("(To add more, follow the Add Animal menu option)");
                        
                        for (int i = 0; i < animalsList.Count; i++)
                        {
                            Console.WriteLine($"{i}. {animalsList[i].Identification}");
                        }

                        var actualAnimalsMenuOption = 0;
                        var isActualAnimalMenuChoiceValid = false;
                        while (!isActualAnimalMenuChoiceValid)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Which animal would you like to interact with?");

                            if (!int.TryParse(Console.ReadLine(), out actualAnimalsMenuOption))
                            {
                                Console.WriteLine("Sorry your choice is incorrect");
                                Console.WriteLine("Please make another choice.");
                                Console.ReadLine();

                                //Clear the console and show the welcome message
                                Console.Clear();
                                Console.WriteLine("Welcome to my one page Animal App");
                                Console.WriteLine();

                                Console.WriteLine("These are your animals that you can interact with:");
                                Console.WriteLine("(To add more, follow the Add Animal menu option)");
                        
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

                        //TODO:Implement the rest of the method here
                        
                        //reset menu choice so we can display the main menu again
                        menuChoice = 0;
                        break;

                    case 3:
                        //TODO: Implement the rest of the method here
                        
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
            get { return $"{Type} - {Name}"; }
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
    }
}