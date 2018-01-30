using System;

namespace gameOfNumbers
{
    class gameOfNumbers
    {
        static void Main(string[] args)
        {
            int inputNumberN = int.Parse(Console.ReadLine());
            int inputNumberM = int.Parse(Console.ReadLine());
            int inputMagicNumber = int.Parse(Console.ReadLine());
            int combinationsCounter = 0;
            int firstNumber = 0;
            int secondNumber = 0;
            for (int counter = inputNumberN; counter <= inputNumberM; counter++)
            {
                for (int check = inputNumberN; check <= inputNumberM; check++)
                {
                    if ((counter + check) == inputMagicNumber)
                    {
                        firstNumber = counter;
                        secondNumber = check;
                        
                    }
                    //Console.WriteLine(check);
                    combinationsCounter++;
                }
            }
            if (firstNumber == 0)
            {
                Console.WriteLine($"{combinationsCounter} combinations - neither equals {inputMagicNumber}");
            }
            else
            {
                Console.WriteLine($"Number found! {firstNumber} + {secondNumber} = {inputMagicNumber}");
            }
        }
    }
}
