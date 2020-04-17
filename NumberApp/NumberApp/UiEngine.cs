using System;

namespace NumberApp
{
    public class UiEngine
    {
        public void Run()
        {
            var three = 3;
            var five = 5;

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
    }
}
