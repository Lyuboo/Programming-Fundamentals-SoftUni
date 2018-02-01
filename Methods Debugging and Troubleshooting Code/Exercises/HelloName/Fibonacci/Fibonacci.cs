using System;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int inputFibonacciNum = int.Parse(Console.ReadLine());
            FibonacciNum(inputFibonacciNum);
        }

        private static void FibonacciNum(int inputFibonacciNum)
        {
            int fibonacciOne = 1;
            int fibonacciTwo = 1;
            int fibonacciThree = 2;
            if (inputFibonacciNum == 0 || inputFibonacciNum == 1)
            {
                fibonacciThree = 1;
            }
            else
            {
                for (int counter = 3; counter <= inputFibonacciNum; counter++)
                {
                    fibonacciOne = fibonacciTwo;
                    fibonacciTwo = fibonacciThree;
                    fibonacciThree = fibonacciOne + fibonacciTwo;

                }
            }
            Console.WriteLine(fibonacciThree);
        }
    }
}
