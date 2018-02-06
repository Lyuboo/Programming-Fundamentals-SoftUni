using System;

namespace LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double inputX1 = double.Parse(Console.ReadLine());
            double inputY1 = double.Parse(Console.ReadLine());
            double inputX2 = double.Parse(Console.ReadLine());
            double inputY2 = double.Parse(Console.ReadLine());
            double inputX3 = double.Parse(Console.ReadLine());
            double inputY3 = double.Parse(Console.ReadLine());
            double inputX4 = double.Parse(Console.ReadLine());
            double inputY4 = double.Parse(Console.ReadLine());

            LongerLinePrint(inputX1, inputY1, inputX2, inputY2, inputX3, inputY3, inputX4, inputY4);
        }

        private static void CenterPointPrint(double x1, double y1, double x2, double y2)
        {
            double point1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double point2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (point1 > point2)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else if (point1 < point2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }

        }

        private static void LongerLinePrint(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double lineOneLenght = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double lineTwoLenght = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));

            if (lineOneLenght < lineTwoLenght)
            {
                CenterPointPrint(x3, y3, x4, y4);
            }
            else
            {

                CenterPointPrint(x1, y1, x2, y2);
            }
        }
    }
}
