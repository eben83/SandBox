using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        static void TimesTable(int number)
        {
            WriteLine($"this is the {number} Times Table");
            
            for (int row = 0; row <= 12; row++)
            {
                WriteLine($"{row} X {number} = {row * number}");
            }
            WriteLine();
        }

        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Write("Enter a number between 0 and 255: ");
                isNumber = int.TryParse(
                    ReadLine(), out int number);

                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("you didn't enter a valid number!");
                }
            } 
            while (isNumber);
        }

        static void Main(string[] args)
        {
            RunTimesTable();
        }
    }
}