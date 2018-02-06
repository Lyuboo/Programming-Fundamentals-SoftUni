using System;
using System.Numerics;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            BigInteger inputNum = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorial(inputNum));
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
    }
}
