using System;

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

                if (i % three == 0 && i % five == 0)
                {
                    Console.WriteLine("Eureka");
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
