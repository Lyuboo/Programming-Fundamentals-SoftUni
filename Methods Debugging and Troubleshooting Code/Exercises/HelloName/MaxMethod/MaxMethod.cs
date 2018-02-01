using System;

namespace MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int inputOne = int.Parse(Console.ReadLine());
            int inputTwo = int.Parse(Console.ReadLine());
            int inputThree = int.Parse(Console.ReadLine());
            int maxOfThree = GetMax(inputOne, GetMax(inputTwo, inputThree));

            Console.WriteLine(maxOfThree);
        }

        private static int GetMax(int numOne, int numTwo)
        {
            if (numOne > numTwo)
            {
                return numOne;
            }
            else
            {
                return numTwo;
            }
        }
    }
}
