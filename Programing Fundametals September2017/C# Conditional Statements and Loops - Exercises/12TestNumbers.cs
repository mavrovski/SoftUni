using System;

namespace _12TestNumbers
{
    public class _12TestNumbers
    {
        public static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int maximumSumBoundary = int.Parse(Console.ReadLine());
            var multiplySum = 0;
            var counter = 0;
            int totalSum = 0;
            for (int i = firstDigit; i >= 1; i--)
            {
                for (int j = 1; j <= secondDigit; j++)
                {
                    multiplySum = 3 * (i * j);
                    totalSum += multiplySum;
                    counter++;
                    if (totalSum >= maximumSumBoundary)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine("Sum: {0} >= {1}", totalSum, maximumSumBoundary);
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations");
            Console.WriteLine("Sum: {0}", totalSum);
        }
    }
}
