using System;

namespace _02Circle_Area_Precision_12_
{
    public class _02Circle_Area_Precision_12_
    {
        public static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double area = Math.Pow(r,2)*Math.PI;

            Console.WriteLine("{0:F12}",area);

        }
    }
}
