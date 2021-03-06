using System;

namespace SemiRefinedApplication
{
    public class Animal
    {
        public AnimalTypes Type { get; set; }
        public string Name { get; set; }
        
        public string Identification
        {
            get { return $" {Type} - {Name}"; }
            
        }
        
        public Animal(string name)
        {
            Name = name;
        }

        public void Run()
        {
            Console.WriteLine("Doof, doof, doof");
            Console.WriteLine("Look at him go!");
            Console.WriteLine("Feeling the earth moving!!");
            Console.WriteLine($"{Type} stops Running. He looks quite Hungry");
            Console.WriteLine($"{Identification} is running....");
            Console.WriteLine("And tired now.");
            Console.WriteLine();
        }

        public void Eat()
        {
            Console.WriteLine($"{Identification} is eating...");
            Console.WriteLine("Munch, munch, munch");
            Console.WriteLine("Look at all that food go down!!!");
            Console.WriteLine("Burp!!"); 
            Console.WriteLine();
        }

        public void Sleep()
        {
            Console.WriteLine($"{Identification} is sleeping...");
            Console.WriteLine("ZZzzZZZzzzZZz");
            Console.WriteLine("How loud can he snore!!!");
            Console.WriteLine($"{Type} can sleep all day");
        }

        public void Fly()
        {
            Console.WriteLine("Is it a bird?!");
            Console.WriteLine("Is it a plane?!");
            Console.WriteLine($"It's a {Type}!!");
        }

        public void Talk()
        {
            switch (Type)
            {
                case AnimalTypes.Dog:
                    DogTalk();
                    break;
                case AnimalTypes.Cat:
                    CatTalk();
                    break;
                case AnimalTypes.Elephant:
                    ElephantTalk();
                    break;
                case AnimalTypes.Salmon:
                    FishTalk();
                    break;
                case AnimalTypes.Penguin:
                    PenguinTalk();
                    break;
                case AnimalTypes.Eagle:
                    EagleTalk();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void EagleTalk()
        {
            Console.WriteLine("Boo");
            Console.WriteLine("Boo");
        }

        private void DogTalk()
        {
            Console.WriteLine("Bark!!");    
            Console.WriteLine("Bark!!");
        }

        private void CatTalk()
        {
            Console.WriteLine("Meow");
            Console.WriteLine("Meow");
        }

        private void ElephantTalk()
        {
            Console.WriteLine("Trumpet!!!!");
            Console.WriteLine("Trumpet!!!!");
        }

        private void FishTalk()
        {
            Console.WriteLine("Bubble");
            Console.WriteLine("Bubble");
        }

        private void PenguinTalk()
        {
            Console.WriteLine("Gak!");
            Console.WriteLine("Gak!!");
        }

        public void Command(AnimalActions animalAction)
        {
            switch(animalAction)
            {
                case AnimalActions.Run:
                    Run();
                    break;
                case AnimalActions.Eat:
                    Eat();
                    break;
                case AnimalActions.Sleep:
                    Sleep();
                    break;
                case AnimalActions.Fly:
                    Fly();
                    break;
                case AnimalActions.Talk:
                    Talk();
                    break;
                default:
                    throw new Exception("Sorry, something went wrong there, " +
                                        "please, make another choice.");
            }
        }
    }
}