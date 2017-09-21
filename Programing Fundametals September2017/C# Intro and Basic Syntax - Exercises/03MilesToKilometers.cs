using System;

namespace _03MilesToKilometers
{
    public class _03MilesToKilometers
    {
        public static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());

            double kilometers = miles * 1.60934;

            Console.WriteLine("{0:F2}",kilometers);
            
        }
    }
}
