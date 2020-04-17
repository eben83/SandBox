using System;

namespace NumberApp
{
    public class UiEngine
    {
        public void Run()
        {
            ShowAllNumbers();
        }

        public void  ShowAllNumbers()
        {
            for (int i = 0; i <= 300; i++)
            {
                MultiplesOfNumberThree(i);

                

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i}. Eureka");
                }
            }

        }

        public void MultiplesOfNumberThree(int x)
        {
            if (x % 3 == 0)
            {
                Console.WriteLine($"{x}.Pluto");
            }
        }

        public void MultipleOfNumbersFive(int x)
        {
            if (x % 5 == 0)
            {
                Console.WriteLine($"{x}. Mars");
            }
        }

        public void MultiplesOfNumberThreeAndFive()
        {
            
        }
        
    }
}