using System;
using AnimalFarm.Core.Application;

namespace AnimalFarm.ConsoleClient.UserInterface.Helpers
{
    public static class UiHelper
    {
        public static void ShowMenuFromEnum<T>(string message) where T : Enum
        {
            //checks for null value
            Console.WriteLine(message ?? string.Empty);
            
            foreach (T menu in Enum.GetValues(typeof(T))) 
                Console.WriteLine($"{Convert.ToInt32(menu)}. {menu.GetDescription()}");
            
            Console.WriteLine();        
        }
        
        public static void ShowWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Welcome, This is my one page Semi Refined Animal App, I hope you will enjoy it");
            Console.WriteLine();
        }
        
        public static void ShowErrorMessage()
        {
            Console.WriteLine("Sorry your choice is incorrect");
            Console.WriteLine("Please, try make another choice.");
            Console.ReadLine();
        }
    }
}