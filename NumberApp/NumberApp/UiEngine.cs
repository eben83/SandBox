using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberApp
{
    public class UiEngine
    {
        public void Run()
        {
            var max = 300;
            var i = 0;

            while (i <= max)
            {
                i += 1;
                multipleOfFive(i);
                multiplesOfThree(i);
                Console.WriteLine(i);
            }


            // var three = 3;
            // var five = 5;
            //
            // for (int i = 0; i < 300; i++)
            // {
            //
            //     if (i % three == 0)
            //     {
            //         Console.WriteLine("pluto");
            //     }
            //
            //     if (i % five == 0)
            //     {
            //         Console.WriteLine("mars");
            //     }
            // }
        }
        
        public void calculation(int x)
        {
            multiplesOfThree(x);
            multipleOfFive(x);
            multipleOfThreeAndFive(x);
        }

        public void multiplesOfThree(int x)
        {
            if (x == 3)
            {
                x += 3;
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