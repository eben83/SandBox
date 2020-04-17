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
                MultiplesOfNumber(i);

                if (i % 5 == 0)
                {
                    Console.WriteLine($"{i}. Mars");
                }
            }

        }

        public void MultiplesOfNumber(int x)
        {
            if (x % 3 == 0)
            {
                Console.WriteLine($"{x}.Pluto");
            }
        }
        
    }
}