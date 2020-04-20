using System.ComponentModel;

namespace AnimalFarm.ConsoleClient.UserInterface
{
    public enum MainMenuChoices
    {

        [Description("Add Animal")]
        AddAnimal = 1,
        [Description("Interact with one animal")]
        InteractWithOneAnimal = 2,
        [Description("Interact with all animals")]
        InteractWithAllAnimals = 3,
        Exit = 4,
    }
}