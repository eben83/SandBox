using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

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

        private int GetMenuChoice( string userMessage, Action menuToShow)
        {
            var getChoiceInt = 0;
            var isChoiceValid = false;
            
            while (!isChoiceValid)
            {
                Console.WriteLine(userMessage);
                
                if (!int.TryParse(Console.ReadLine(), out getChoiceInt ))
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
        //method animals menu
        public void animalMenu()
        {
            
        }
        
        //action actions menu
    }
}


