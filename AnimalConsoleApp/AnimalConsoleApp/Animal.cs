using System;

namespace AnimalConsoleApp
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
                    throw new ArgumentOutOfRangeException(nameof(animalAction), "Use the enum directly"); 
            }
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
            switch (Type)
            {
                case AnimalTypes.Dog:
                    DogSleep();
                    break;
                case AnimalTypes.Cat:
                    CatSleep();
                    break;
                case AnimalTypes.Elephant:
                    ElephantSleep();
                    break;
                case AnimalTypes.Salmon:
                    SalmonSleep();
                    break;
                case AnimalTypes.Penguin:
                    peniguinSleep();
                    break;
                case AnimalTypes.Eagle:
                    EagleSleep();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }   
        }
        private void DogSleep()
        {
            Console.WriteLine("zzzZZZZzzzZZZ");
            Console.WriteLine("You looking for a warm water bottle");
            Console.WriteLine($"A {Type}, they will want to sleep on top of you all year reound");
        }
        private void CatSleep()
        {
            Console.WriteLine("zzzZZZZzzzZZZ");
            Console.WriteLine($"A {Type}, they love to sleep");
            Console.WriteLine("Just don't think they will want to sleep with you");
        }
        private void ElephantSleep()
        {
            Console.WriteLine("zzzZZZZzzzZZZ");
            Console.WriteLine($"If you've ever seen and {Type} sleep");
            Console.WriteLine("They are loud and the can't stop farting...");
        }
        private void SalmonSleep()
        {
            Console.WriteLine("zzzZZZZzzzZZZ");
            Console.WriteLine($"{Type}, are you really asking?");
            Console.WriteLine("I don't think anyone even knows if they can.");
        }
        private void peniguinSleep()
        {
            Console.WriteLine("zzzZZZZzzzZZZ");
            Console.WriteLine($"{Type}, they will huddle in groups");
            Console.WriteLine(" to keep warm and safe.");
        }
        private void EagleSleep()
        {
            Console.WriteLine("zzzZZZZzzzZZZ");
            Console.WriteLine($"We all know, looking as majestic and an{Type}");
            Console.WriteLine("You need the beauty ZZZzzz's");
        }

        
        public void Fly()
        {
            switch (Type)
            {
                case AnimalTypes.Dog:
                    DogFly();
                    break;
                case AnimalTypes.Cat:
                    CatFly();
                    break;
                case AnimalTypes.Elephant:
                    ElephantFly();
                    break;
                case AnimalTypes.Salmon:
                    SalmonFly();
                    break;
                case AnimalTypes.Penguin:
                    PenguinFly();
                    break;
                case AnimalTypes.Eagle:
                    EagleFly();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }
        private void DogFly()
        {
            Console.WriteLine("Fly? Dogs don't Fly");
            Console.WriteLine("But Greyhounds can make it look like they can fly");
        }
        private void CatFly()
        {
            Console.WriteLine("mmm, you are getting judged");
            Console.WriteLine("Judged, by this computer");
        }
        private void ElephantFly()
        {
            Console.WriteLine("HAHAHAHAHAHAHA!");
            Console.WriteLine("Dude, Dumbo is not real!!!");
        }
        private void SalmonFly()
        {
            Console.WriteLine($"well, {Type} could be seen as flying");
            Console.WriteLine("when they Fly upstream...");
        }
        private void PenguinFly()
        {
            Console.WriteLine("this must be the funniest animal, they really do");
            Console.WriteLine("wish they could fly, they just got to be happy with the water flying");
        }
        private void EagleFly()
        {
            Console.WriteLine("Now we talking!!,");
            Console.WriteLine($"The majestic {Type} makes this look way to easy.");
        }

        
        private void Talk()
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
                    SalmonTalk();
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
            Console.WriteLine("Hello");
            Console.WriteLine("Boo");
            Console.WriteLine("Boo");
        }
        private void DogTalk()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Bark!!");    
            Console.WriteLine("Bark!!");
        }
        private void CatTalk()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Meow");
            Console.WriteLine("Meow");
        }
        private void ElephantTalk()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Trumpet!!!!");
            Console.WriteLine("Trumpet!!!!");
        }
        private void SalmonTalk()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Bubble");
            Console.WriteLine("Bubble");
        }
        private void PenguinTalk()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Gak!");
            Console.WriteLine("Gak!!");
        }

    }
}