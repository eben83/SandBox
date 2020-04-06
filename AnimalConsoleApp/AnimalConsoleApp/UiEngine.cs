using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AnimalConsoleApp
{
    public class UiEngine
    {
        private string userMessage;
        string menuChoice;
        
        public void Run()
        {
           
            
            while (menuChoice != "4")
            {
                Welcome();
                MainMenu();
                menuChoice = Console.ReadLine();
            }
        }
        private void Welcome()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my Animal App");
            Console.WriteLine();
        }
​
        private void MainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Add animal");
            Console.WriteLine("2. Interact with animal");
            Console.WriteLine("3. Interact with all animals");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
        }

        public void GetMenuChoice(string userMessage)
        {
            string getChoice;
            
            Console.WriteLine(userMessage);
            bool result = int.TryParse(getChoice = Console.ReadLine(), out int getChoiceInt);

            if (result )
            {
                
            }
            else
            {
                Console.WriteLine("Sorry your choice is incorrect");
                Console.WriteLine("Please make another choice.");
            }
        }
            
            
    }
}


