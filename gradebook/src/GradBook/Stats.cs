using System;

namespace GradBook
{
    public class stats
    {
        public double Average
        {
            get
            {
                return sum / count;
            }
        }
        public double High;
        public double low;
        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 90.0:
                        return 'A';

                    case var d when d >= 80.0:
                        return 'B';

                    case var d when d >= 70.0:
                        return 'C';

                    case var d when d >= 60.0:
                        return 'D';

                    default:
                        return 'F';
                }
            }
        }
        public double sum;
        public int count;

        public void Add(double number)
        {
            sum += number;
            count += 1;
            low = Math.Min(number, low);
            High = Math.Max(number, High);
        }

        public stats()
        {
            count = 0;
            High = double.MinValue;
            low = double.MaxValue;
        }
    }

}