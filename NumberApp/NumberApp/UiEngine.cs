using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace NumberApp
{
    public class UiEngine
    {
        public void Run()
        {
            var three = 3;
            var five = 5;
            
            for (int i = 0; i <= 300; i++)
            {
                if (i % three == 0 && i % five == 0)
                {
                    Console.WriteLine("Eureka");
                    continue;
                }
                if (i % three == 0)
                {
                    Console.WriteLine("pluto");
                    continue;
                }
            
                if (i % five == 0)
                {
                    Console.WriteLine("mars");
                    continue;
                }


                Console.WriteLine(i);
            }
        }
        
        public void multiplesOfThree(int x)
        {
            if (x == 3)
            {
                Console.WriteLine($"Pluto");
            }
        }

        public void multipleOfFive(int x)
        {
            if (x % 5 == 0)
            {
                Console.WriteLine($"Mars");
            }
        }

        public void multipleOfThreeAndFive(int x)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.WriteLine($"Eureka");
            }
        }
    }
    
}

// var max = 300;
// var i = 0;

// while (i <= max)
// {
//     i += 1;
//     multipleOfFive(i);
//     multiplesOfThree(i);
//     Console.WriteLine(i);
// }