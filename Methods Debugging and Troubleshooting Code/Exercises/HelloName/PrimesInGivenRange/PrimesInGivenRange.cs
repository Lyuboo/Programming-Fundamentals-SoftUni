using System;
using System.Collections.Generic;

namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main()
        {
            int inputNumOne = int.Parse(Console.ReadLine());
            int inputNumTwo = int.Parse(Console.ReadLine());

            PrimesInRange(inputNumOne, inputNumTwo);
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
        private static void PrimesInRange(int limitOne, int limitTwo)
        {
            List<int> primeNumbers = new List<int>();
            if (limitOne > limitTwo)
            {
                int exchangeNumber = limitOne;
                limitOne = limitTwo;
                limitTwo = exchangeNumber;
            }
            for (int counter = limitOne; counter <= limitTwo; counter++)
            {
                if (IsPrimeNumber(counter))
                {
                    primeNumbers.Add(counter);
                }
            }
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                Console.Write(primeNumbers[i]);
                if (i < primeNumbers.Count - 1)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
