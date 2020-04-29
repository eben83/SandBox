using System;

namespace NumberApp
{
    public class UiEngine
    {
            const int three = 3;
            const int five = 5;
            const int ThreeAndFive = 3 * 5;
        public void Run()
        {

            for (int i = 1; i <= 300; i++)
            {
                if (i % three == 0 && i % five == 0)
                {
                    Console.WriteLine("Eureka");
                    continue;
                }
                
                if (i % three == 0)
                {
                    Console.WriteLine("Pluto");
                    continue;
                }

                if (i % five == 0)
                {
                    Console.WriteLine("Mars");
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        public int Factor(int number){
            if (number % three == 0 && number % five == 0)
            {
                Console.WriteLine("EureKa");
            }
            return Factor(number);
        }
    }
}
