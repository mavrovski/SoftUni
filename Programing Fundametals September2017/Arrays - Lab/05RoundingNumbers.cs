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
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("{0} = {1}", numbers[i], Math.Round(numbers[i], MidpointRounding.AwayFromZero));
            //}
        }
    }
}
