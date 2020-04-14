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
            var animalsList = new List<Animal>();

            while (menuChoice != EXIT_MENU_CHOICE)
            {
                switch (menuChoice)
                {
                    case 0:
                        menuChoice = ShowMainMenuAndGetMainMenuChoice(animalsList);
                        break;

                    case 1:
                        ShowAnimalMenuAndAddAnimal(animalsList);
                        menuChoice = 0;
                        break;

                    case 2:
                        InteractWithOneAnimal(animalsList);
                        menuChoice = 0;
                        break;

                    case 3:
                        var isActualAnimalActionOption = false;
                        var allAnimalActionOption = 0;
                        Console.Clear();
                        Console.WriteLine("Welcome, This is my one page Semi Refined Animal App, I hope you will enjoy it");
                        Console.WriteLine();
                        Console.WriteLine("Once you make your choice - All the animals will perform the action");

                        Console.WriteLine();
                        Console.WriteLine($"What action would yo like all your animals to do?");
                        Console.WriteLine("1. Eat");
                        Console.WriteLine("2. Sleep");
                        Console.WriteLine("3. Run");
                        Console.WriteLine("4. Fly");
                        Console.WriteLine("5. Talk");

                        if (!int.TryParse(Console.ReadLine(), out allAnimalActionOption))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Sorry your choice is incorrect");
                            Console.WriteLine("Please, try make another choice.");
                            Console.WriteLine("Press enter to carry on.");
                            Console.ReadLine();
                            menuChoice = 0;
                            Console.ReadLine();
                            
                            Console.Clear();
                            Console.WriteLine("Welcome, This is my one page Semi Refined Animal App, I hope you will enjoy it");
                        }
                        else
                        {
                            isActualAnimalActionOption = true;
                        }
                        
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
                                    if (pet.Type == "Penguin")
                                    {
                                        pet.Fly();    
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Sorry, but your {pet.Type} does not fly.");
                                        Console.WriteLine("choose another animal- if you wish to fly.");
                                        Console.WriteLine();
                                        Console.WriteLine("Press enter to carry on.");
                                        Console.ReadLine();
                                        menuChoice = 3;
                                    }
                                    
                                    break;
                                case 3:
                                    Console.WriteLine(pet.Identification);
                                    pet.Run();
                                    break;
                                case 4:
                                    Console.WriteLine(pet.Identification);
                                    pet.Sleep();
                                    break;
                                case 5:
                                    if (pet.Type == "Dog")
                                    {
                                        pet.DogTalk();
                                    }
                                    else if (pet.Type == "Cat")
                                    {
                                        pet.CatTalk();
                                    }
                                    else if (pet.Type == "Elephant")
                                    {
                                        pet.ElephantTalk();
                                    }
                                    else if (pet.Type == "Fish")
                                    {
                                        pet.FishTalk();
                                    }
                                    else if (pet.Type == "Penguin")
                                    {
                                        pet.PenguinTalk();
                                    }

                                    Console.WriteLine();
                                    Console.WriteLine("Press enter to carry on");
                                    Console.ReadLine();
                                    break;
                                default:
                                    throw new Exception("Wrong Choice, Please TRY again...");
                            }
                        }
                        
                        Console.WriteLine("Press Enter to carry on:");
                        Console.ReadLine();

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
            return GetMainMenuChoice();
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

        public int GetMainMenuChoice()
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

        public  void ShowAnimalMenuAndAddAnimal(List<Animal> AddAnimalToList)
        {
            ShowWelcomeMessage();
            ShowAnimalMenu();

            string animalType = MapAnimalMenuChoiceToAnimalType(GetAnimalMenuChoice());

            Console.WriteLine($"What name would you like to give your new {animalType}");
            string animalName = Console.ReadLine();

            Console.WriteLine($"Brilliant, You have named your {animalType}, {animalName}- " +
                              $"Congratulations on the new member to the family...");
            Console.WriteLine("Press Enter to carry on.");
            Console.ReadLine();

            var animal = new Animal(animalName);
            animal.Type = animalType;
            AddAnimalToList.Add(animal);
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

        public int GetAnimalMenuChoice()
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
            Console.WriteLine();
            Console.WriteLine("You are able to interact with the following animals:");
            Console.WriteLine("(To add more, follow the Add Animal menu option one)");
            Console.WriteLine();
            ShowAnimalListSummary(animalInteractList);

            Animal selectedAnimal = animalInteractList[GetAnimalMenuChoice()];

            Console.WriteLine($"Your {selectedAnimal.Type} can perform the following actions:");
            AnimalActionMenu();



            var animalActionOption = 0;
            var isActualAnimalActionOption = false;

            while (! isActualAnimalActionOption)
            {
                if (!int.TryParse(Console.ReadLine(), out animalActionOption))
                {
                    ShowErrorMessage();
                
                    ShowWelcomeMessage();
                }
                else
                {
                    isActualAnimalActionOption = true;
                }
            }
//this is as far as I got.
            PerformAnimalAction(GetAnimalChoice(), animalInteractList);

            Console.WriteLine("Press enter to carry on:");
            Console.ReadLine();
        }

        public int GetAnimalChoice()
        {
            var actualAnimalsMenuOption = 0;
            var isActualAnimalMenuChoiceValid = false;
            while (!isActualAnimalMenuChoiceValid)
            {
                Console.WriteLine();
                Console.WriteLine("Which of your animals would you like to interact with?");

                if (!int.TryParse(Console.ReadLine(), out actualAnimalsMenuOption))
                {
                    ShowErrorMessage();
                    ShowWelcomeMessage();

                    Console.WriteLine("These are your animals that you are able to interact with:");
                    Console.WriteLine("(To add more, follow the Add Animal menu option one)");
                }
                else
                {
                    isActualAnimalMenuChoiceValid = true;
                }
            }

            return actualAnimalsMenuOption;
        }

        public int GetAnimalActionMenuChoice(List<Animal>animalInteractList)
        {
            var actualAnimalsMenuOption = 0;
            var isActualAnimalMenuChoiceValid = false;
            while (!isActualAnimalMenuChoiceValid)
            {
                Console.WriteLine();
                Console.WriteLine("Which of your animals would you like to interact with?");

                if (!int.TryParse(Console.ReadLine(), out actualAnimalsMenuOption))
                {
                    ShowErrorMessage();
                    ShowWelcomeMessage();

                    Console.WriteLine("These are your animals that you are able to interact with:");
                    Console.WriteLine("(To add more, follow the Add Animal menu option one)");
            
                    ShowAnimalListSummary(animalInteractList);
                }
                else
                {
                    isActualAnimalMenuChoiceValid = true;
                }
            }

            return actualAnimalsMenuOption;
        }

        public void AnimalActionMenu()
        {
            Console.WriteLine("1. Eat");
            Console.WriteLine("2. Sleep");
            Console.WriteLine("3. Run");
            Console.WriteLine("4. Fly");
            Console.WriteLine("5. Talk");
        }

        public void PerformAnimalAction(int animalActionOption, List<Animal> selectedAnimalAction)
        {
            switch(animalActionOption)
            {
                case 1:
                    selectedAnimalAction.Eat();
                    break;
                case 2:
                    selectedAnimalAction.Sleep();
                    break;
                case 3:
                    selectedAnimalAction.Run();
                    break;
                case 4:
                    if (selectedAnimalAction.Type == "Penguin")
                    {
                        selectedAnimalAction.Fly();
                    }
                    else
                    {
                        Console.WriteLine($"Sorry your {selectedAnimalAction.Type} does not have the ability to fly.");
                        Console.WriteLine();
                    }
                    
                    break;
                case 5:
                    AnimalActionTalk();
                    break;
                default:
                    throw new Exception("Sorry, something went wrong there, " +
                                        "please, make another choice.");
            }
        }

        public void AnimalActionTalk()
        {
            if (selectedAnimalAction.Type == "Dog")
            {
                selectedAnimalAction.DogTalk();
            }
            else if (selectedAnimalAction.Type == "Cat")
            {
                selectedAnimalAction.CatTalk();
            }
            else if (selectedAnimalAction.Type == "Elephant")
            {
                selectedAnimalAction.ElephantTalk();
            }
            else if (selectedAnimalAction.Type == "Fish")
            {
                selectedAnimalAction.FishTalk();
            }
            else if (selectedAnimalAction.Type == "Penguin")
            {
                selectedAnimalAction.PenguinTalk();
            }
            
        }
    }
}