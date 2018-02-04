using System;

namespace VariableInHEXFormat
{
    class VariableInHEXFormat
    {
        static void Main(string[] args)
        {
            string inputHEXNumber = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(inputHEXNumber, 16));
        }
    }
}
