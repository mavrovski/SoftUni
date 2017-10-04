using System;

namespace _09MultiplyEvensbyOdd
{
    public class _09MultiplyEvensbyOdd
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var result = GetMultipleOfEvensAndOdds(Math.Abs(n));
            Console.WriteLine(result);
        }
        private static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEven = GetSumEven(n);
            int sumOdd = GetSumOdd(n);
            return sumEven * sumOdd;
        }

        private static int GetSumOdd(int n)
        {
            int sum = 0;
            while (n>0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2==0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;

        }

        private static int GetSumEven(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 1)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
    }
}
