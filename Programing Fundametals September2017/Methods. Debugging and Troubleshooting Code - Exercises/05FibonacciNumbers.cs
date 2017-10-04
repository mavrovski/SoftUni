using System;

namespace _05FibonacciNumbers
{
    public class _05FibonacciNumbers
    {
        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            FibonacciNumbers(n);
        }

        private static void FibonacciNumbers(long n)
        {
            long oneStepBehind = 1;
            long currrentNumber = 0;
            for (int i = 0; i <= n; i++)
            {
                long tempLong = currrentNumber;
                currrentNumber += oneStepBehind;
                oneStepBehind = tempLong;
            }
            Console.WriteLine(currrentNumber);
        }
    }
}
