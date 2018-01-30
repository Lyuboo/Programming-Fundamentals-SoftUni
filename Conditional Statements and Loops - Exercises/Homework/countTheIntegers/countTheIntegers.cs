using System;

namespace countTheIntegers
{
    class countTheIntegers
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (count = 0; ; count++)
            {
                try
                {
                    int inputNumber = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    break;
                    //throw;
                }
            }
            Console.WriteLine(count);
        }
    }
}
