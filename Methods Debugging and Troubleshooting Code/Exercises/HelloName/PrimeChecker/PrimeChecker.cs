using System;

namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrimeNumber(number));
        }

        private static bool IsPrimeNumber(long number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }


            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
