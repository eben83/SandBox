using System;
using System.Collections.Generic;
using AnimalFarm.ConsoleClient.UserInterface.Helpers;
using AnimalFarm.Core.Domain;

namespace AnimalFarm.ConsoleClient.UserInterface
{
    public class UiEngine
    {
        public void Run()
        {
            const int EXIT_MENU_CHOICE = 4;

            int menuChoice = 0;
            var animals = new List<Animal>();

            while (menuChoice != EXIT_MENU_CHOICE)
            {
                switch (menuChoice)
                {
                    case 0:
                        menuChoice = GetChoiceFromMainMenu(animals);
                        break;

                    case 1:
                        AnimalMenuHelper.AddAnimal(animals);
                        menuChoice = 0;
                        break;

                    case 2:
                        InteractWithOneAnimal(animals);
                        menuChoice = 0;
                        break;

                    case 3:
                        InteractWithAllAnimals(animals);
                        menuChoice = 0;
                        break;
                }
            }
        }
        private static int GetChoiceFromMainMenu(List<Animal> animalsList)
        {
            UiHelper.ShowWelcomeMessage();
            ShowAnimalListSummary(animalsList);
            MainMenuHelper.ShowMainMenu();
            return MainMenuHelper.GetValidMainMenuChoice();
        }
        private static void ShowAnimalListSummary(List<Animal> listOfAnimals)
        {
            if (listOfAnimals.Count == 0)
            {
                Console.WriteLine("No animals loaded");
                return;
            }

            Console.WriteLine();
            var nounToUse = listOfAnimals.Count > 1 ? "animals" : "animal";
            Console.WriteLine($"You currently have {listOfAnimals.Count} {nounToUse} loaded.");
            Console.WriteLine();
            Console.Write($"Your {nounToUse}:");
            foreach (var pet in listOfAnimals)
            {
                Console.Write($" {pet.Identification} |");
            }
        }
        private static void InteractWithOneAnimal(List<Animal> animalInteractList)
        {
            UiHelper.ShowWelcomeMessage();
            AnimalMenuHelper.ShowInteractMenu(animalInteractList);
            var selectedAnimal = AnimalMenuHelper.GetAnimalFromMenu(animalInteractList);
            // AnimalMenuHelper.ShowAnimalActionMenu(selectedAnimal.Type);
            
            if (selectedAnimal.HungerLevel <= 3)
            {
                Console.WriteLine("Please Feed me- you slave driver!!");
                Console.WriteLine($"{(int)AnimalActions.Eat}. {AnimalActions.Eat}");
                AnimalActions animalAction = (AnimalActions) AnimalMenuHelper.GetValidAnimalActionMenuChoice(selectedAnimal.Type);
                selectedAnimal.Command(animalAction);
            }
            else
            {
                AnimalMenuHelper.ShowAnimalActionMenu(selectedAnimal.Type);
                AnimalActions animalAction = (AnimalActions) AnimalMenuHelper.GetValidAnimalActionMenuChoice(selectedAnimal.Type);
                selectedAnimal.Command(animalAction);
            }
            
            Console.WriteLine("Press enter to carry on:");
            Console.ReadLine();
        }
        private static void InteractWithAllAnimals(List<Animal> animals)
        {
            UiHelper.ShowWelcomeMessage();
            AnimalMenuHelper.ShowAnimalActionMenu(null);
            AnimalActions animalActionSelected = (AnimalActions) AnimalMenuHelper.GetValidAnimalActionMenuChoice(null);

            foreach (var animal in animals)
            {
                animal.Command(animalActionSelected);
            }
            
            Console.WriteLine("Press Enter to carry on:");
            Console.ReadLine();
        }
    }
}