using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace SemiRefinedApplication
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
                        menuChoice = ShowMainMenuAndGetMainMenuChoice(animals);
                        break;

                    case 1:
                        ShowAnimalMenuAndAddAnimal(animals);
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

        

        public int ShowMainMenuAndGetMainMenuChoice(List<Animal> animalsList)
        {
            ShowWelcomeMessage();
            ShowAnimalListSummary(animalsList);
            ShowMainMenu();
            return GetValidMainMenuChoice();
        }
        
        public void ShowWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Welcome, This is my one page Semi Refined Animal App, I hope you will enjoy it");
            Console.WriteLine();
        }

        public void ShowMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Add animal");
            Console.WriteLine("2. Interact with animal");
            Console.WriteLine("3. Interact with all animals");
            Console.WriteLine("4. Exit");
            Console.WriteLine();   
        }

        public void ShowAnimalListSummary(List<Animal> listOfAnimals)
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

        public void ShowErrorMessage()
        {
            Console.WriteLine("Sorry your choice is incorrect");
            Console.WriteLine("Please, try make another choice.");
            Console.ReadLine();
        }

        public int GetValidMainMenuChoice()
        {
            var menuSelection = 0;
            
            var isMainMenuChoiceValid = false;
            while (!isMainMenuChoiceValid)
            {
                Console.WriteLine("Please, make a selection, to carry on.");

                if (!int.TryParse(Console.ReadLine(), out menuSelection))
                {
                    ShowErrorMessage();
                    ShowWelcomeMessage();
                    ShowMainMenu();
                }
                else
                {
                    isMainMenuChoiceValid = true;
                }
            }
            return menuSelection;
        }

        public  void ShowAnimalMenuAndAddAnimal(List<Animal> addAnimalToList)
        {
            ShowWelcomeMessage();
            ShowAnimalMenu();

            string animalType = MapAnimalMenuChoiceToAnimalType(GetValidAnimalMenuChoice());

            Console.WriteLine($"What name would you like to give your new {animalType}");
            string animalName = Console.ReadLine();

            Console.WriteLine($"Brilliant, You have named your {animalType}, {animalName}- " +
                              $"Congratulations on the new member to the family...");
            Console.WriteLine("Press Enter to carry on.");
            Console.ReadLine();

            var animal = new Animal(animalName);
            animal.Type = animalType;
            addAnimalToList.Add(animal);
        }

        public void ShowAnimalMenu()
        {
            Console.WriteLine("The following animals are available:");
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");
            Console.WriteLine("3. Elephant");
            Console.WriteLine("4. Fish");
            Console.WriteLine("5. Penguin");
            Console.WriteLine();   
        }

        public int GetValidAnimalMenuChoice()
        {
            var menuSelection = 0;
            var isAnimalMenuChoiceValid = false;
            while (!isAnimalMenuChoiceValid)
            {
                Console.WriteLine("Which animal would you like to add?");

                if (!int.TryParse(Console.ReadLine(), out menuSelection))
                {
                    ShowErrorMessage();
                    ShowWelcomeMessage();
                    ShowAnimalMenu();                    
                }
                else
                {
                    isAnimalMenuChoiceValid = true;
                }
            }
            
            return menuSelection;
        }

        public string MapAnimalMenuChoiceToAnimalType(int animalMenuChoice)
        {
            
            switch (animalMenuChoice)
            {
                case 1:
                    return "Dog";
                case 2:
                    return "Cat";
                case 3:
                    return "Elephant";
                case 4:
                    return "Fish";
                case 5:
                    return "Penguin";
                default: throw new Exception("Invalid choice, please try again.");
            }
        }

        public void InteractWithOneAnimal(List<Animal> animalInteractList)
        {
            ShowWelcomeMessage();
            ShowInteractMenu(animalInteractList);
            var selectedAnimal = GetAnimalFromMenu(animalInteractList);
            ShowAnimalActionMenu(selectedAnimal.Type);
            var animalActionChoice =GetValidAnimalActionMenuChoice(selectedAnimal.Type);
            PerformAnimalAction(animalActionChoice, selectedAnimal);
            
            Console.WriteLine("Press enter to carry on:");
            Console.ReadLine();
        }

        public void ShowInteractMenu(List<Animal> animalsList)
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

        public Animal GetAnimalFromMenu(List<Animal> actualAnimals)
        {
            var actualAnimalsMenuChoice = 0;
            var isActualAnimalMenuChoiceValid = false;
            while (!isActualAnimalMenuChoiceValid)
            {
                Console.WriteLine("Which of your animals would you like to interact with?");

                if (!int.TryParse(Console.ReadLine(), out actualAnimalsMenuChoice))
                {
                    ShowErrorMessage();
                    ShowWelcomeMessage();
                    ShowInteractMenu(actualAnimals);
                }
                else
                {
                    isActualAnimalMenuChoiceValid = true;
                }
            }

            return actualAnimals[actualAnimalsMenuChoice];
        }
        
        static void ShowAnimalActionMenu(string animalType)
        {
            if (string.IsNullOrWhiteSpace(animalType))
            {
                Console.WriteLine("Which action would you like your animals to perform");
            }
            else
            {
                Console.WriteLine($"Which action would you like your {animalType} to perform");
            }
            
            Console.WriteLine("1. Eat");
            Console.WriteLine("2. Sleep");
            Console.WriteLine("3. Run");
            Console.WriteLine("4. Fly");
            Console.WriteLine("5. Talk");
            Console.WriteLine();
            
        }
        

        public int GetValidAnimalActionMenuChoice(string animalType)
        {
            var animalActionOption = 0;
            var isActualAnimalActionOption = false;
            
            while (! isActualAnimalActionOption)
            {
                if (!int.TryParse(Console.ReadLine(), out animalActionOption))
                {
                    ShowErrorMessage();
                    ShowWelcomeMessage();
                    ShowAnimalActionMenu(animalType);
                    
                    
                }
                else
                {
                    isActualAnimalActionOption = true;
                }
            }

            return animalActionOption;
        }

        public void PerformAnimalAction(int menuChoice ,Animal animal)
        {
            switch(menuChoice)
            {
                case 1:
                    animal.Eat();
                    break;
                case 2:
                    animal.Sleep();
                    break;
                case 3:
                    animal.Run();
                    break;
                case 4:
                    animal.Fly();                    
                    break;
                case 5:
                    animal.Talk();
                    break;
                default:
                    throw new Exception("Sorry, something went wrong there, " +
                                        "please, make another choice.");
            }
        }

        public void InteractWithAllAnimals(List<Animal> animals)
        {
            ShowWelcomeMessage();
            ShowAnimalActionMenu(null);
            var actionMenuSelected = GetValidAnimalActionMenuChoice(null);

            foreach (var animal in animals)
                PerformAnimalAction(actionMenuSelected, animal);
            
            Console.WriteLine("Press Enter to carry on:");
            Console.ReadLine();
        }
    }
}