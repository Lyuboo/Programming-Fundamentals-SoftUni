using System;

namespace CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double sideInput = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            CubeCalc(sideInput, parameter);
        }

        static void CubeCalc(double side, string parameter)
        {
            double property = 0.00;
            switch (parameter)
            {
                case "face":
                    property = Math.Sqrt(2 * side * side);
                    break;
                case "space":
                    property = Math.Sqrt(3 * side * side);
                    break;
                case "volume":
                    property = (side * side * side);
                    break;
                case "area":
                    property = (6 * side * side);
                    break;
            }
            Console.WriteLine($"{property:F2}");
        }
    }
}
