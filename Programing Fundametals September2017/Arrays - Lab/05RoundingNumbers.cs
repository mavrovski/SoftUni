using System;
using System.Linq;

namespace _05RoundingNumbers
{
    public class _05RoundingNumbers
    {
        public static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ')
                .Select(double.Parse)
                .ToArray();

            foreach (var num in numbers)
            {
                Console.WriteLine("{0} = {1}",num,Math.Round(num,MidpointRounding.AwayFromZero));
            }
         
        }
    }
}
