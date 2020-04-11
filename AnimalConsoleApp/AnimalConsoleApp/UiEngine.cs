using System;
using System.Collections.Generic;

namespace AnimalConsoleApp
{
    public class UiEngine
    {
        private const int EXIT_MENU_CHOICE = 4;

        public void Run()
        {
            int menuChoice = 0;
            var animalsList = new List<IAnimal>();

            while (menuChoice != EXIT_MENU_CHOICE)
            {
                switch (menuChoice)
                {
                    case 0:
                        Welcome();
                        MainMenu();
                        break;
                    case 1:
                        AddAnimal();
                        animalsList.Add(AddAnimal());
                        MainMenu();
                        menuChoice = 0;
                        break;
                    case 2:
                        InteractWithAnimal();    
                        menuChoice = 0;
                        break;
                    case 3:
                        InteractWithAnimals();
                        break;
                    default:
                        menuChoice = 0;
                        break;
                }

                if (menuChoice != 0)
                    menuChoice = 0;
                else
                    menuChoice = GetMenuChoice("Please make a choice, fool!!!", MainMenu);
            }
        }

        private void Welcome()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my Animal App");
            Console.WriteLine();
            // Console.WriteLine("The Following are Animals are loaded:");
            //TODO: Lets show a message here with the animal identifications that was already added.
        }

        private void MainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Add animal");
            Console.WriteLine("2. Interact with animal");
            Console.WriteLine("3. Interact with all animals");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
        }

        private void AnimalMenu()
        {
            Console.WriteLine("The following animals are available:");
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");
            Console.WriteLine("3. Elephant");
            Console.WriteLine("4. Fish");
        }

        private void ActionMenu()
        {
            Console.WriteLine("Animals can perform the following actions:");
            Console.WriteLine("1. Eat");
            Console.WriteLine("2. Sleep");
            Console.WriteLine("3. Run");
        }

        private int GetMenuChoice(string userMessage, Action menuToShow)
        {
            var getChoiceInt = 0;
            var isChoiceValid = false;

            while (!isChoiceValid)
            {
                Console.WriteLine(userMessage);

                if (!int.TryParse(Console.ReadLine(), out getChoiceInt))
                {
                    Console.WriteLine("Sorry your choice is incorrect");
                    Console.WriteLine("Please make another choice.");
                    Console.ReadLine();
                    Welcome();
                    menuToShow();
                }
                else
                {
                    isChoiceValid = true;
                    Welcome();
                }
            }

            return getChoiceInt;
        }

        private void AddAnimal()
        {
            Welcome();
            AnimalMenu();

            var animalOption = GetMenuChoice("Select the type of animal you would like to add.", AnimalMenu);
            Console.WriteLine();
            var animalType = GetAnimalType(animalOption);
            
            Console.WriteLine($"What name would you like to give your new {animalType}");
            string animalName = Console.ReadLine();

            Console.WriteLine($"Brilliant, Your {animalType} now has the name of {animalName}- " +
                              $"Congratulations on the new member to the family...");
            Console.WriteLine("Press Enter to carry on.");
            Console.ReadLine();
            
        }

        private static string GetAnimalType(int animalOption)
        {
            switch (animalOption)
            {
                case 1: return "Dog";
                case 2: return "Cat";
                case 3: return "Elephant";
                case 4: return "Fish";
                default: throw new Exception("Invalid animal type.");
            }
        }

        public void InteractWithAnimal()
        {
            Welcome();
            AnimalMenu();

            var animalOption = GetMenuChoice("Which animal would like to interact with?", AnimalMenu);
            var animalType = GetAnimalType(animalOption);
            
            Welcome();
            Console.WriteLine($"You have chosen: {animalType}");
            ActionMenu();

            var actionOption = GetMenuChoice($"What would you like your {animalType} to do?", ActionMenu);

        }
        
        private void InteractWithAnimals()
        {
            
            
        }
    }
}


