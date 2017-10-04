using System;

namespace _10CubeProperties
{
    public class _10CubeProperties
    {
        public static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();
            Console.WriteLine("{0:f2}", CubeProperties(side, property));
           
        }

        private static double CubeProperties(double side, string property)
        {
            double sum = 0;
            switch (property)
            {
                case "face":
                    sum = Math.Round(Math.Sqrt(2 * Math.Pow(side, 2)),2);
                    break;
                case "space":
                    sum = Math.Round(Math.Sqrt(3 * (Math.Pow(side, 2))), 2);
                    break;
                case "volume":
                    sum = Math.Round(Math.Pow(side, 3),2);
                    break;
                case "area":
                    sum = Math.Round(6 * Math.Pow(side,2),2);
                    break;
                default:
                    break;
            }
            return sum;
        }
    }
}
