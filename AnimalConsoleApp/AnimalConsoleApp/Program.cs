
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace AnimalConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            new UiEngine().Run();
        }
        

        private static void GetAndPerformAnimalAction(List<Animal> animals)
        {
            string animalAction;
            string animalActionFirstWord;
            string animalActionSecondWord;

            Console.WriteLine("Animals can do the following:");
            Console.WriteLine("Run, Sleep, Eat");
            Console.WriteLine();
            Console.WriteLine("Specify the animal and action you want to perform:");
            Console.WriteLine("Example: Elephant - Run / ELEPHANT-RUN / Elephant- Run / Elephant - RUN");
            animalAction = Console.ReadLine().ToLower().Replace(" ", "");
            animalActionFirstWord = animalAction.Substring(0, animalAction.IndexOf("-"));
            animalActionSecondWord = animalAction.Substring(animalAction.IndexOf("-") + 1);

            foreach (var animal in animals)
            {
                if (string.Compare(animal.Type, animalActionFirstWord, StringComparison.InvariantCultureIgnoreCase) ==
                    0)
                {
                    if (string.Compare(animalActionSecondWord, "run", StringComparison.InvariantCultureIgnoreCase) == 0)
                    {
                        animal.Run();
                    }

                    if (animalActionSecondWord == "sleep")
                    {
                        animal.Sleep();
                    }

                    if (animalActionSecondWord == "eat")
                    {
                        animal.Eat();
                    }
                }
            }
        }
    }
}
