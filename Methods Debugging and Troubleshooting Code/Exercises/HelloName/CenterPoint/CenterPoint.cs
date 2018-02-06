using System;

namespace CenterPoint
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double inputX1 = double.Parse(Console.ReadLine());
            double inputY1 = double.Parse(Console.ReadLine());
            double inputX2 = double.Parse(Console.ReadLine());
            double inputY2 = double.Parse(Console.ReadLine());

            CenterPointPrint(inputX1, inputY1, inputX2, inputY2);
        }

        private static void CenterPointPrint(double x1, double y1, double x2, double y2)
        {
            double point1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double point2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (point1 > point2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }

        }
    }
}
