using System;

namespace AnimalConsoleApp
{
    public class Dog
    {
        
        public AnimalTypes Type { get; set; }
        public string Name { get; set; }
        public string Identification
        {
            get { return $" {Type} - {Name}"; }
        }
        
        public Dog(string name)
        {
            Name = name;
        }

        public void Command(AnimalActions animalAction)
        {
            switch(animalAction)
            {
                case AnimalActions.Run:
                    DogRun();
                    break;
                case AnimalActions.Eat:
                    DogEat();
                    break;
                case AnimalActions.Sleep:
                    DogSleep();
                    break;
                case AnimalActions.Fly:
                    DogFly();
                    break;
                case AnimalActions.Talk:
                    DogTalk();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(animalAction), "Use the enum directly"); 
            }
        }
        
        private void DogRun()
        {
            Console.WriteLine("Whoosh");
            Console.WriteLine($"Play time for a {Type}, {Type}'s love to run");
            Console.WriteLine("They are the happiest while running around");
        }
        private void DogEat()
        {
            Console.WriteLine("Burp");
            Console.WriteLine($"Look at this {Type}, how fast?");
            Console.WriteLine("How fast do they eat?");
        }
        private void DogSleep()
        {
            Console.WriteLine("zzzZZZZzzzZZZ");
            Console.WriteLine("You looking for a warm water bottle");
            Console.WriteLine($"A {Type}, they will want to sleep on top of you all year reound");
        }
        private void DogFly()
        {
            Console.WriteLine("Fly? Dogs don't Fly");
            Console.WriteLine("But Greyhounds can make it look like they can fly");
        }
        private void DogTalk()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Bark!!");    
            Console.WriteLine("Bark!!");
        }

    }
}
    