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
            Console.WriteLine("Animal is running");
            // switch (Type)
            // {
            //     case AnimalTypes.Dog:
            //         DogRun();
            //         break;
            //     case AnimalTypes.Cat:
            //         CatRun();
            //         break;
            //     case AnimalTypes.Elephant:
            //         ElephantRun();
            //         break;
            //     case AnimalTypes.Salmon:
            //         SalmonRun();
            //         break;
            //     case AnimalTypes.Penguin:
            //         PenguinRun();
            //         break;
            //     case AnimalTypes.Eagle:
            //         EagleRun();
            //         break;
            //     default:
            //         throw new ArgumentOutOfRangeException();
            // }
        }
        
        private void DogRun()
        {
            Console.WriteLine("Whoosh");
            Console.WriteLine($"Play time for a {Type}, {Type}'s love to run");
            Console.WriteLine("They are the happiest while running around");
        }
        private void CatRun()
        {
            Console.WriteLine("Whoosh");
            Console.WriteLine($"this is funny you think a {Type} will run");
            Console.WriteLine("they will rather watch you run");
        }
        private void ElephantRun()
        {
            Console.WriteLine("Whoosh");
            Console.WriteLine($"when looking at an {Type}, you think you're safe");
            Console.WriteLine($"Guess again, an {Type}, they are really fast");
        }
        private void SalmonRun()
        {
            Console.WriteLine("Whoosh");
            Console.WriteLine("Okay, this is a weird one- they can't actually run like the res of us");
            Console.WriteLine($"But once a year they have a {Type} run");
        }
        private void PenguinRun()
        {
            Console.WriteLine("Whoosh");
            Console.WriteLine($"Do {Type} have Knees?");
            Console.WriteLine("They run like drunk people...");
        }
        private void EagleRun()
        {
            Console.WriteLine("Whoosh");
            Console.WriteLine($"Why would you think an {Type} will even think of running");
            Console.WriteLine("They fly faster");
        }


        public void Eat()
        {
            Console.WriteLine("Animal is eating");
            // switch (Type)
            // {
            //     case AnimalTypes.Dog:
            //         DogEat();
            //         break;
            //     case AnimalTypes.Cat:
            //         CatEat();
            //         break;
            //     case AnimalTypes.Elephant:
            //         ElephantEat();
            //         break;
            //     case AnimalTypes.Salmon:
            //         SalmonEat();
            //         break;
            //     case AnimalTypes.Penguin:
            //         PenguinEat();
            //         break;
            //     case AnimalTypes.Eagle:
            //         EagleEat();
            //         break;
            //     default:
            //         throw new ArgumentOutOfRangeException();
            // }
        }
        private void DogEat()
        {
            Console.WriteLine("Burp");
            Console.WriteLine($"Look at this {Type}, how fast?");
            Console.WriteLine("How fast do they eat?");
        }
        private void CatEat()
        {
            Console.WriteLine("Burp");
            Console.WriteLine("This must be a myth, you put food out,");
            Console.WriteLine($"But you never know who's {Type} you feed");
        }
        private void ElephantEat()
        {
            Console.WriteLine("Burp");
            Console.WriteLine($"{Type}'s can never get enough food");
            Console.WriteLine("They will devour a full tree bu themselves");
        }
        private void SalmonEat()
        {
            Console.WriteLine("Burp");
            Console.WriteLine($"I wouldn't be able to say anything here");
            Console.WriteLine($"{Type} eat like {Type}, doing {Type} things");
        }
        private void PenguinEat()
        {
            Console.WriteLine("Burp");
            Console.WriteLine("We can all watch this fake fling, wannabe bird");
            Console.WriteLine($"But, a {Type} can hunt just like any other well oiled machine");
        }
        private void EagleEat()
        {
            Console.WriteLine("Burp");
            Console.WriteLine("If you are squeamish, look away!");
            Console.WriteLine($"an {Type}, will eat other birds or fish");
        }
        

        public void Sleep()
        {
            Console.WriteLine("Animal is Sleeping");
            // switch (Type)
            // {
            //     case AnimalTypes.Dog:
            //         DogSleep();
            //         break;
            //     case AnimalTypes.Cat:
            //         CatSleep();
            //         break;
            //     case AnimalTypes.Elephant:
            //         ElephantSleep();
            //         break;
            //     case AnimalTypes.Salmon:
            //         SalmonSleep();
            //         break;
            //     case AnimalTypes.Penguin:
            //         PeniguinSleep();
            //         break;
            //     case AnimalTypes.Eagle:
            //         EagleSleep();
            //         break;
            //     default:
            //         throw new ArgumentOutOfRangeException();
            // }   
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
        private void PeniguinSleep()
        {
            Console.WriteLine("zzzZZZZzzzZZZ");
            Console.WriteLine($"{Type}, they will huddle in groups");
            Console.WriteLine("To keep warm and safe.");
        }
        private void EagleSleep()
        {
            Console.WriteLine("zzzZZZZzzzZZZ");
            Console.WriteLine($"We all know, looking as majestic and an{Type}");
            Console.WriteLine("You need the beauty ZZZzzz's");
        }

        
        public void Fly()
        {
            Console.WriteLine("Animal is Flying");
            // switch (Type)
            // {
            //     case AnimalTypes.Dog:
            //         DogFly();
            //         break;
            //     case AnimalTypes.Cat:
            //         CatFly();
            //         break;
            //     case AnimalTypes.Elephant:
            //         ElephantFly();
            //         break;
            //     case AnimalTypes.Salmon:
            //         SalmonFly();
            //         break;
            //     case AnimalTypes.Penguin:
            //         PenguinFly();
            //         break;
            //     case AnimalTypes.Eagle:
            //         EagleFly();
            //         break;
            //     default:
            //         throw new ArgumentOutOfRangeException();
            // }

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
            Console.WriteLine($"Well, {Type} could be seen as flying");
            Console.WriteLine("When they Fly upstream...");
        }
        private void PenguinFly()
        {
            Console.WriteLine("This must be the funniest animal, they really do");
            Console.WriteLine("Wish they could fly, they just got to be happy with the water flying");
        }
        private void EagleFly()
        {
            Console.WriteLine("Now we talking!!,");
            Console.WriteLine($"The majestic {Type} makes this look way to easy.");
        }

        
        public void Talk()
        {
            Console.WriteLine("Animal is Talking");
            // switch (Type)
            // {
            //     case AnimalTypes.Dog:
            //         DogTalk();
            //         break;
            //     case AnimalTypes.Cat:
            //         CatTalk();
            //         break;
            //     case AnimalTypes.Elephant:
            //         ElephantTalk();
            //         break;
            //     case AnimalTypes.Salmon:
            //         SalmonTalk();
            //         break;
            //     case AnimalTypes.Penguin:
            //         PenguinTalk();
            //         break;
            //     case AnimalTypes.Eagle:
            //         EagleTalk();
            //         break;
            //     default:
            //         throw new ArgumentOutOfRangeException();
            // }
        }
        private void EagleTalk()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Giggle");
            Console.WriteLine("Giggle");
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