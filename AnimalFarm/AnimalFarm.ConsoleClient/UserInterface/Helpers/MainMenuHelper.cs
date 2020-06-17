using System;
using AnimalFarm.Core.Application;

namespace AnimalFarm.ConsoleClient.UserInterface.Helpers
{
    public static class MainMenuHelper
    {
        public static void ShowMainMenu()
        {
            UiHelper.ShowMenuFromEnum<MainMenuChoices>(null);
        }
        public static int GetValidMainMenuChoice()
        {
            var menuSelection = 0;
            
            var isMainMenuChoiceValid = false;
            while (!isMainMenuChoiceValid)
            {
                Console.WriteLine("Please, make a selection, to carry on.");

                if (!int.TryParse(Console.ReadLine(), out menuSelection))
                {
                    UiHelper.ShowErrorMessage();
                    UiHelper.ShowWelcomeMessage();
                    ShowMainMenu();
                }
                else
                {
                    isMainMenuChoiceValid = true;
                }
            }
            return menuSelection;
        }
    }
}