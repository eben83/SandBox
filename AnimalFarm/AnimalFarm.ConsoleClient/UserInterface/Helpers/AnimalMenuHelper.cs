using System;
using System.Collections.Generic;
using AnimalFarm.Core.Domain;
using AnimalFarm.Core.Infrastructure;

namespace AnimalFarm.ConsoleClient.UserInterface.Helpers
{
    public class AnimalMenuHelper
    {
        
        public static void AddAnimal(List<Animal> addAnimalToList)
        {
            UiHelper.ShowWelcomeMessage();
            AnimalMenuHelper.ShowAnimalMenu();

            AnimalTypes animalType =(AnimalTypes) GetValidAnimalMenuChoice();

            Console.WriteLine($"What name would you like to give your new {animalType}");
            string animalName = Console.ReadLine();

            Console.WriteLine($"Brilliant, You have named your {animalType}, {animalName}");
            Console.WriteLine("Congratulations on the new member to the family...");
            Console.WriteLine("Press Enter to carry on.");
            Console.ReadLine();

            var animal = AnimalFactory.CreateAnimal(animalType, animalName);
            addAnimalToList.Add(animal);
        }
        public static void ShowAnimalActionMenu(AnimalTypes? animalType)
        {
            var message =!animalType.HasValue
                ? "Which action would you like your animals to perform"
                : $"Which action would you like your {animalType} to perform";

            UiHelper.ShowMenuFromEnum<AnimalTypes>(message);
            
            Console.WriteLine();
            
        }
        public static void ShowInteractMenu(List<Animal> animalsList)
        {
            Console.WriteLine();
            Console.WriteLine("You are able to interact with the following animals:");
            Console.WriteLine("(To add more, follow the Add Animal menu option one)");
            Console.WriteLine();
            for (int i = 0; i < animalsList.Count; i++)
            {
                Console.WriteLine($"{i}. {animalsList[i].Identification}");
            }
        }
        public static Animal GetAnimalFromMenu(List<Animal> actualAnimals)
        {
            var actualAnimalsMenuChoice = 0;
            var isActualAnimalMenuChoiceValid = false;
            while (!isActualAnimalMenuChoiceValid)
            {
                Console.WriteLine("Which of your animals would you like to interact with?");

                if (!int.TryParse(Console.ReadLine(), out actualAnimalsMenuChoice))
                {
                    UiHelper.ShowErrorMessage();
                    UiHelper.ShowWelcomeMessage();
                    ShowInteractMenu(actualAnimals);
                }
                else
                {
                    isActualAnimalMenuChoiceValid = true;
                }
            }

            return actualAnimals[actualAnimalsMenuChoice];
        }
        public static int GetValidAnimalActionMenuChoice(AnimalTypes? animalType)
        {
            var animalActionOption = 0;
            var isActualAnimalActionOption = false;
            
            while (! isActualAnimalActionOption)
            {
                if (!int.TryParse(Console.ReadLine(), out animalActionOption))
                {
                    UiHelper.ShowErrorMessage();
                    UiHelper.ShowWelcomeMessage();
                    ShowAnimalActionMenu(animalType);
                }
                else
                {
                    isActualAnimalActionOption = true;
                }
            }

            return animalActionOption;
        }
        private static void ShowAnimalMenu()
        {
            UiHelper.ShowMenuFromEnum<AnimalTypes>("The following animals are available:");
        }
        private static int GetValidAnimalMenuChoice()
        {
            var menuSelection = 0;
            var isAnimalMenuChoiceValid = false;
            while (!isAnimalMenuChoiceValid)
            {
                Console.WriteLine("Which animal would you like to add?");

                if (!int.TryParse(Console.ReadLine(), out menuSelection))
                {
                    UiHelper.ShowErrorMessage();
                    UiHelper.ShowWelcomeMessage();
                    ShowAnimalMenu();                    
                }
                else
                {
                    isAnimalMenuChoiceValid = true;
                }
            }
            
            return menuSelection;
        }
    }
}