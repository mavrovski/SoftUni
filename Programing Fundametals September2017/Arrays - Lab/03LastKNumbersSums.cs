using System;

namespace _03LastKNumbersSums
{
    public class _03LastKNumbersSums
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var numbers = new long[n];
            numbers[0] = 1;
            for (int i = 1; i < n; i++)
            {
                var start = 0;
                if (i>=k)
                {
                    start = i - k;
                }
                numbers[i] = SumNumbers(numbers, start, i);
            }
            // Console.WriteLine(string.Join(" ",numbers));
            foreach (var num in numbers)
            {
                Console.Write("{0} ",num);
            }

        }

        private static long SumNumbers(long[] numbers, int startIndex, int endIndex)
        {
            long sum = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
