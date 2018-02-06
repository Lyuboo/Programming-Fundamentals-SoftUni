using System;

namespace GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string inputFigure = Console.ReadLine();
            double printValue = FigureArea(inputFigure);

            Console.WriteLine($"{printValue:F2}");
        }

        static double FigureArea(string figure)
        {
            double area = 0.00;

            switch (figure)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    area = 0.5 * side * height;
                    break;
                case "square":
                    side = double.Parse(Console.ReadLine());
                    area = side * side;
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    area = width * height;
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * radius * radius;
                    break;
            }
            return area;
        }
    }
}
