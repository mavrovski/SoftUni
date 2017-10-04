using System;

namespace _06PrimeChecker
{
    public class _06PrimeChecker
    {
        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            var result = IsPrime(n);
            Console.WriteLine(result);


        }

        private static bool IsPrime(long n)
        {
            bool isPrime = true;
            if (n == 0 || n == 1)
            {
                isPrime = false;
                return isPrime;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        
                    }
                }
                return isPrime;
            }
            
        }
    }
}
