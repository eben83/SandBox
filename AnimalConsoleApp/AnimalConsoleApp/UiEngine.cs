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
            //add in list and then list add return...
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
                    case 1 :
                        AddAnimal();
                        animalsList.Add(AddAnimal());
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
            Console.WriteLine("The following animals are loaded:");
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
        
        private IAnimal AddAnimal()
        {
            Welcome();
            AnimalMenu();
            
            var animalOption = GetMenuChoice("Select the type of animal you would like to add.", AnimalMenu);
            Console.WriteLine();
                        //TODO: Now get the animal name from the user
            var animalType = (AnimalTypes) animalOption;
            Console.WriteLine($"What name would you like to give you new {animalType}");
            string animalName = Console.ReadLine();
            
            Console.WriteLine($"Brilliant, Your {animalType} now has the name of {animalName}- " +
                              $"Congratulations on the new member to the family...");
            Console.WriteLine("Press Enter to carry on.");
            Console.ReadLine();

            return AnimalFactory.CreateIAnimal(animalType, animalName);
            
            //TODO: Lets add the animal to our list of animals.
            //We will use a factory to create the animal. Add a AnimalFactory class.
            //The class will have one method called Create that requires a parameter of type AnimalsTypes
            //Then use a switch to new up the correct animal based on the animal type parameter.
        }

        public IAnimal InteractWithAnimal()
        {
            Welcome();
            AnimalMenu();
            
            var animalOption = GetMenuChoice("Which animal would like to interact with?", AnimalMenu);
            
            //You can do the reverse (int) animalType, by casting an int back to the enum.
            var animalType = (AnimalTypes) animalOption;
            
            //TODO: Geta the animal from our list
            Welcome();
            Console.WriteLine($"You have chosen: {animalType}");
            ActionMenu();

            //Personalize the message a bit more once we have the animal
            var actionOption = GetMenuChoice($"What would you like your {animalType} to do?", ActionMenu);
            //TODO: Perform action
            var actionType = (AnimalActions) actionOption;
            Console.WriteLine(actionType);
            var animalAction = AddAnimal();
            return animalAction;
        }

        private void InteractWithAnimals()
        {
            
            
        }
        
        
    }
}


