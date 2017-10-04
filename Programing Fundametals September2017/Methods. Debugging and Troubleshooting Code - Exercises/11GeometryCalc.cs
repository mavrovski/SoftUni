using System;

namespace _11GeometryCalc
{
    public class _11GeometryCalc
    {
        public static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine();
            switch (typeOfFigure)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", Math.Round(TriangleCalculator(side,height),2));
                    break;
                case "square":
                    double sideSquare = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round(SquareCalculator(sideSquare),2));
                    break;
                case "rectangle":
                    double widthRec = double.Parse(Console.ReadLine());
                    double heightRec = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}",Math.Round(RectangleCalculator(widthRec, heightRec),2));
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round(CircleCalculator(radius),2));
                    break;

                default:
                    break;
            }
        }

        private static double CircleCalculator(double radius)
        {
            
            double result = Math.PI * Math.Pow(radius, 2);
            return result;
        }

        private static double RectangleCalculator(double widthRec, double heightRec)
        {
            double result = widthRec * heightRec;
            return result;

        }

        private static double SquareCalculator(double sideSquare)
        {
            double result = sideSquare * sideSquare;
            return result;
        }

        private static double TriangleCalculator(double side, double height)
        {
            double result = 0.5*side * height;
            return result;
        }
    }
}
