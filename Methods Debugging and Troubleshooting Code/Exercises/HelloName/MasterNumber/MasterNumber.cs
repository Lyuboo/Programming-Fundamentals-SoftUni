using System;

namespace MasterNumber
{
    class MasterNumber
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            for (int currentNum = 0; currentNum < inputNum; currentNum++)
            {
                if (IsSymmetric(currentNum) && SumOfDigits(currentNum) % 7 == 0 && ContainsEvenDigit(currentNum))
                {
                    Console.WriteLine(currentNum);
                }
                
            }
        }

        static bool IsSymmetric(int number)
        {
            string currentNumber = number.ToString();
            int counter = 0;

            for (int i = currentNumber.Length - 1; i >= 0; i--)
            {
                if (currentNumber[i] != currentNumber[counter])
                {
                    return false;
                }
                counter++;

            }
            return true;
        }
        static int SumOfDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            return sum;
        }
        static bool ContainsEvenDigit(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;

                if (digit % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }
    }
}
