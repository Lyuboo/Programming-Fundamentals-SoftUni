using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            BigInteger inputNum = BigInteger.Parse(Console.ReadLine());
            BigInteger factorial = CalculateFactorial(inputNum);

            Console.WriteLine(CountTrailingZeroes(factorial));
        }

        static BigInteger CalculateFactorial(BigInteger number)
        {
            BigInteger factorial = 1;

            for (int currentNum = 1; currentNum <= number; currentNum++)
            {
                factorial *= currentNum;
            }
            return factorial;
        }

        static int CountTrailingZeroes(BigInteger number)
        {
            int counter = 0;

            while (number != 0)
            {
                BigInteger digit = number % 10;
                if (digit == 0)
                {
                    counter++;
                }
                else
                {
                    break;
                }
                number /= 10;
            }
            return counter;
        }
    }
}
