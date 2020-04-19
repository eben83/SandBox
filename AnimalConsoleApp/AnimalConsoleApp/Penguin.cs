using System;

namespace AnimalConsoleApp
{
    public class Penguin : Animal

    {
    public AnimalTypes Type => AnimalTypes.Penguin;
    public string Name { get; set; }

    public string Identification
    {
        get { return $" {Type} - {Name}"; }
    }

    public Penguin(string name) : base(name)
    {
        Name = name;
    }

    // public void Command(AnimalActions animalAction)
    // {
    //     switch(animalAction)
    //     {
    //         case AnimalActions.Run:
    //             Run();
    //             break;
    //         case AnimalActions.Eat:
    //             Eat();
    //             break;
    //         case AnimalActions.Sleep:
    //             Sleep();
    //             break;
    //         case AnimalActions.Fly:
    //             Fly();
    //             break;
    //         case AnimalActions.Talk:
    //             Talk();
    //             break;
    //         default:
    //             throw new ArgumentOutOfRangeException(nameof(animalAction), "Use the enum directly"); 
    //     }
    // }

    private void Run()
    {
        Console.WriteLine("Whoosh");
        Console.WriteLine($"Play time for a {Type}, {Type}'s love to run");
        Console.WriteLine("They are the happiest while running around");
    }

    private void Eat()
    {
        Console.WriteLine("Burp");
        Console.WriteLine($"Look at this {Type}, how fast?");
        Console.WriteLine("How fast do they eat?");
    }

    private void Sleep()
    {
        Console.WriteLine("zzzZZZZzzzZZZ");
        Console.WriteLine("You looking for a warm water bottle");
        Console.WriteLine($"A {Type}, they will want to sleep on top of you all year reound");
    }

    private void Fly()
    {
        Console.WriteLine("Fly? Dogs don't Fly");
        Console.WriteLine("But Greyhounds can make it look like they can fly");
    }

    private void Talk()
    {
        Console.WriteLine("Hello");
        Console.WriteLine("Bark!!");
        Console.WriteLine("Bark!!");
    }


    }
}