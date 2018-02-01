using System;

namespace NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            decimal inputNumber = decimal.Parse(Console.ReadLine());
            ReversedNumber(inputNumber);
        }

        private static void ReversedNumber(decimal inputNumber)
        {
            int increasedByTen = 1;
            int counter = 0;

            while (increasedByTen - inputNumber != 0)
            {
                decimal tenTimesInputNum = inputNumber * 10;
                increasedByTen = (int)tenTimesInputNum;
                inputNumber = inputNumber * 10;
                counter++;
            }

            decimal reversedNumber = 0;
            while (increasedByTen != 0)
            {
                reversedNumber = (reversedNumber * 10) + (increasedByTen / 10);
            }
            for (int i = 0; i < counter; i++)
            {
                reversedNumber = reversedNumber / 10M;
            }
            Console.WriteLine(reversedNumber);
        }
    }
}
