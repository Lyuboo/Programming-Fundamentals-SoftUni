using System;

namespace differentNumbers
{
    class differentNumbers
    {
        static void Main(string[] args)
        {
            int inputNumMin = int.Parse(Console.ReadLine());
            int inputNumMax = int.Parse(Console.ReadLine());
            if (inputNumMin > inputNumMax)
            {
                int changeNum = inputNumMin;
                inputNumMin = inputNumMax;
                inputNumMax = changeNum;
            }
            for (int num1 = inputNumMin; num1 <= (inputNumMax - 4); num1++)
            {
                for (int num2 = (num1 + 1); num2 <= (inputNumMax - 3); num2++)
                {
                    for (int num3 = (num2 + 1); num3 <= (inputNumMax - 2); num3++)
                    {
                        for (int num4 = (num3 + 1); num4 <= (inputNumMax - 1); num4++)
                        {
                            for (int num5 = (num4 + 1); num5 <= inputNumMax; num5++)
                            {
                                Console.WriteLine($"{num1} {num2} {num3} {num4} {num5}");
                            }
                        }
                    }
                }
            }
            if ((inputNumMax - inputNumMin) < 4)
            {
                Console.WriteLine("No");
            }
        }
    }
}
