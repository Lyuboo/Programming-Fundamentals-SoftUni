using System;

namespace testNumbers
{
    class testNumbers
    {
        static void Main(string[] args)
        {
            int inputNumberN = int.Parse(Console.ReadLine());
            int inputNUmberM = int.Parse(Console.ReadLine());
            int sumBoundary = int.Parse(Console.ReadLine());
            int combinationsCounter = 0;
            int totalSum = 0;
            for (int decreaseNum = inputNumberN; decreaseNum >= 1; decreaseNum--)
            {
                for (int increaseNum = 1; increaseNum <= inputNUmberM; increaseNum++)
                {
                    if (totalSum >= sumBoundary)
                    {
                        break;
                    }
                    combinationsCounter++;
                    totalSum = totalSum + (3 * decreaseNum * increaseNum);
                    //Console.WriteLine($"{decreaseNum} {increaseNum}   ");
                    
                }
            }
            if (totalSum >= sumBoundary)
            {
                Console.WriteLine($"{combinationsCounter} combinations\nSum: {totalSum} >= {sumBoundary}");
            }
            else
            {
                Console.WriteLine($"{combinationsCounter} combinations\nSum: {totalSum}");
            }
        }
    }
}
