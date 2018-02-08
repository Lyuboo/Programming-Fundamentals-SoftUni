using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int currentStart = 0;
            int bestStart = 0;
            int currentLenght = 0;
            int bestLenght = 0;

            for (int counter = 1; counter < numbers.Count; counter++)
            {
                if (numbers[counter] == numbers[counter - 1])
                {
                    currentLenght++;
                    
                    bestStart = currentStart;
                }
                else
                {

                    currentStart = counter;
                }

            }

            for (int counter = bestStart; counter < bestStart + bestLenght; counter++)
            {
                Console.Write(numbers[counter] + " ");
            }
        }
    }
}
