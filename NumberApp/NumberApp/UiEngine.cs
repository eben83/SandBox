using System;

namespace NumberApp
{
    public class UiEngine
    {
        public void Run()
        {
            ShowAllNumbers();
        }

        public void ShowAllNumbers()
        {
            for (int i = 0; i <= 300; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}