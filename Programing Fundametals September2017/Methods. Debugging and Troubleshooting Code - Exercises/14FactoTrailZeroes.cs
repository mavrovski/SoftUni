using System;
using System.Numerics;

namespace _13Factorial
{
    public class _13Factorial
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger factorial = CalculateFactorial(num);
            int zeroes = ZeroesCount(factorial);
            Console.WriteLine(zeroes);
        }

        private static BigInteger CalculateFactorial(int num)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        public static int ZeroesCount(BigInteger n)
        {
            int zero = 0;
            bool hasZero = true;
            while (hasZero == true)
            {
                BigInteger digit = n % 10;
                n /= 10;
                if (digit == 0)
                {
                    zero++;
                }
                else
                {
                    hasZero = false;
                }
            }
            return zero;
        }
    }
}