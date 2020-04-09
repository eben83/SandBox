using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Xml;

namespace AnimalConsoleApp
{
    public class UiEngine
    {
        private const int EXIT_MENU_CHOICE = 4;

        public void Run()
        {
            int menuChoice = 0;

            while (menuChoice != EXIT_MENU_CHOICE)
            {
                switch (menuChoice)
                {
                    case 0:
                        Welcome();
                        MainMenu();
                        break;
                    case 1 :
                        AddAnimal();
                        break;
                    case 2:
                        InteractWithAnimal();
                        break;
                    case 3:
                        InteractWithAnimals();
                        break;
                    default:
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
            foreach (var animalType in Enum.GetValues(typeof(AnimalTypes)))
                Console.WriteLine($"{(int) animalType}. {animalType}");
        }

        private void ActionMenu()
        {
            foreach (var animalAction in Enum.GetValues(typeof(AnimalActions)))
                Console.WriteLine($"{(int) animalAction}. {animalAction}");
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
            //TODO: Now get the animal name from the user
            
            //TODO: Lets add the animal to our list of animals.
            //We will use a factory to create the animal. Add a AnimalFactory class.
            //The class will have one method called Create that requires a parameter of type AnimalsTypes
            //Then use a switch to new up the correct animal based on the animal type parameter.
            
        }

        private void InteractWithAnimal()
        {
            Welcome();
            AnimalMenu();
            
            var animalOption = GetMenuChoice("Which animal would like to interact with?", AnimalMenu);
            
            //You can do the reverse (int) animalType, by casting an int back to the enum.
            var animalType = (AnimalTypes) animalOption;
            
            //TODO: Get the animal from our list
            Welcome();
            ActionMenu();

            //Personalize the message a bit more once we have the animal
            var actionOption = GetMenuChoice("What would you like your animal to do?", ActionMenu);
            //TODO: Perform action
        }

        private void InteractWithAnimals()
        {
            
            
        }
        
        
    }
}


