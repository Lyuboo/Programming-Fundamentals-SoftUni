using System;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputArrayOne = Console.ReadLine();
            string inputArrayTwo = Console.ReadLine();
            string[] arrayOne = inputArrayOne.Split(' ');
            string[] arrayTwo = inputArrayTwo.Split(' ');
            int leftCounter = 0;
            int rightCounter = 0;
            int biggerSize = 0;

            if (arrayOne.Length < arrayTwo.Length)
            {
                biggerSize = arrayTwo.Length;
            }
            else
            {
                biggerSize = arrayOne.Length;
            }

            for (int counter = 0; counter < biggerSize; counter++)
            {
                if (arrayOne[counter] == arrayTwo[counter])
                {
                    leftCounter++;
                }
                else
                {
                    break;
                }
            }
              

        }
    }
}
