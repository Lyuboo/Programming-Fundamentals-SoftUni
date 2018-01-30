using System;

namespace triangleOfNumbers
{
    class triangleOfNumbers
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            for (int counterHeight = 1; counterHeight <= inputNumber; counterHeight++)
            {
                for (int counterWidth = 0; counterWidth < counterHeight; counterWidth++)
                {
                    Console.Write($"{counterHeight} ");
                }
                Console.WriteLine("");
            }
        }
    }
}
