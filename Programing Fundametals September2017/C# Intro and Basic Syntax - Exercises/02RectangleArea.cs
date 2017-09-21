using System;

namespace _02RectangleArea
{
    public class _02RectangleArea
    {
        public static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;

            Console.WriteLine("{0:F2}", area);
            

        }
    }
}
