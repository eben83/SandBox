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
            for (int i = 1; i <= 300; i++)
            {
                MultiplesOfNumberThreeAndFive(i);
                MultipleOfNumbersFive(i);
                MultiplesOfNumberThree(i);
                Console.WriteLine(i);
            }

        }

        public int MultiplesOfNumberThree(int x)
        {
            
            if (x % 3 == 0)
            {
                Console.WriteLine($"{x}.Pluto");
            }

            return x;
        }

        public int MultipleOfNumbersFive(int x)
        {
            if (x % 5 == 0)
            {
                Console.WriteLine($"{x}. Mars");
            }

            return x;
        }

        public int MultiplesOfNumberThreeAndFive(int x)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.WriteLine($"{x}. Eureka");
            }

            return x;
        }
        
    }
}