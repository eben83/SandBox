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
                Welcome();
                MainMenu();
                menuChoice = GetMenuChoice("Please make a choice, fool!!!", MainMenu);
                AnimalMenu();
                menuChoice = GetMenuChoice("Please, make a choice", AnimalMenu);
                ActionMenu();
                menuChoice = GetMenuChoice("Make an action choice", ActionMenu);
            }
        }

        private void Welcome()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my Animal App");
            Console.WriteLine();
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

        private void AnimalMenu()
        {
            int menuChoice = 1;
            foreach (var animalType in Enum.GetValues(typeof(AnimalTypes)))
                Console.WriteLine($"{(int) animalType}. {animalType}");
            //(int) animalType- displays the int of the array
        }

        private void ActionMenu()
        {
            int menuChoice = 2;
            foreach (var animalAction in Enum.GetValues(typeof(AnimalActions)))
                Console.WriteLine($"{(int) animalAction}. {animalAction}");

        }
    }
}

//method- return animals menu

//method- return actions menu
    



