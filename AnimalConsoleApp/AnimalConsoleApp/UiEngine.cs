namespace AnimalConsoleApp
{
    public class UiEngine
    {
         public void Run()
        {
            var animals = new List<Animal>();


            Console.WriteLine("Welcome to my Animal App");
            Console.WriteLine();

            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();

            Console.WriteLine($"Top of the morning to ya, {name}");
            Console.WriteLine();

            Console.WriteLine("Name any amount of animals you like:");
            var animalTypes = Console.ReadLine().Split(",");

            foreach (var animalType in animalTypes)
            {
                var animal = new Animal();
                animal.Type = animalType;
                animals.Add(animal);
            }

            Console.WriteLine("Enter as many names as you wish:");
            var names = Console.ReadLine().Split(",");

            for (int index = 0; index < animals.Count; index++)
            {
                animals[index].Name = names[index];

            }

            Console.WriteLine();

            Console.WriteLine($"You entered the following choices (Total {animals.Count})");

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Identification}");
            }

            Console.WriteLine();

            GetAndPerformAnimalAction(animals);
            GetAndPerformAnimalAction(animals);
            GetAndPerformAnimalAction(animals);
            
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}