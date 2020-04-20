using System.ComponentModel;

namespace AnimalConsoleApp
{
    public enum MainMenuChoices
    {

        [Description("Add Animal")]
        Add_AnAnimal = 1,
        [Description("Interact with one animal")]
        Interact_With_One_Animal = 2,
        [Description("Interact with all animals")]
        Interact_With_All_Animals = 3,
        Exit = 4,
    }
}