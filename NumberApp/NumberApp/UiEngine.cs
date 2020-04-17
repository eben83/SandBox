using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberApp
{
    public class UiEngine
    {
        public void Run()
        {
            int[] numbers = new int[300];
            for (int i = 0; i <= 300; i++)
            {
                numbers.Append(i);
            }
        }
        
        public void calculation(int x)
        {
            multiplesOfThree(x);
            multipleOfFive(x);
            multipleOfThreeAndFive(x);
        }

        public void multiplesOfThree(int x)
        {
            if (x % 3 == 0)
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