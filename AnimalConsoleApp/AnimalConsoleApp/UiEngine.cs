using System;
using System.Collections.Generic;

namespace AnimalConsoleApp
{
    public class UiEngine
    {
        public void Run()
        {
            
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
            Console.WriteLine("1. Add animal");
            Console.WriteLine("2. Interact with animal");
            Console.WriteLine("3. Interact with all animals");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
        }
    }
}