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
                if (i % 3)
                {
                    Console.WriteLine("Pluto");
                }
            }

        }

        public int MultiplesOfNumber(int x)
        {
        }
        
    }
}