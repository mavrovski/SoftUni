using System;

namespace _12RectangleProperties
{
    public class _12RectangleProperties
    {
        public static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            double perimeter = (sideA + sideB) * 2;
            double area = sideA * sideB;
            double digonal = Math.Sqrt(Math.Pow(sideA,2)+Math.Pow(sideB,2));

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(digonal);

        }
    }
}
