using System;
using AnimalFarm.Core.Application;

namespace AnimalFarm.ConsoleClient.UserInterface.Helpers
{
    public class UiHelper
    {
        public void ShowMenuFromEnum<T>(string message) where T : Enum
        {
            //checks for null value
            Console.WriteLine(message ?? string.Empty);
            
            foreach (T menu in Enum.GetValues(typeof(T))) 
                Console.WriteLine($"{Convert.ToInt32(menu)}. {menu.GetDescription()}");
            
            Console.WriteLine();
        }
    }
}