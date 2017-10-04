using System;
using System.Collections.Generic;
using System.Linq;

namespace _07PrimesGivenRange
{
    public class _07PrimesGivenRange
    {
        public static void Main(string[] args)
        {

            int startPrime  = int.Parse(Console.ReadLine());
            int endPrime  = int.Parse(Console.ReadLine());
            var findPrime = FindPrimesInRange(startPrime, endPrime);
            for (int i = 0; i <= findPrime.Count-2; i++)
            {
                Console.Write("{0}, ",findPrime[i]);
           
            }
            Console.Write("{0}",findPrime[findPrime.Count - 1]);
            //Console.WriteLine(string.Join(',', findPrime));
            //foreach (var prime in findPrime)
            //{
            //    var count = 0;
            //    count++;
            //    if (prime < endPrime)
            //    {
            //        Console.Write("{0}, ", prime);
            //    }
            //    else if (findPrime.Count==count)
            //    {
            //        Console.Write("{0} ", prime);
            //    }
                

            //}

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
        static List<int> FindPrimesInRange(int startPrime,int endPrime)
        {
            List<int> checkPrimes = new List<int>();
            for (int i = startPrime; i <=endPrime; i++)
            {
                if (IsPrime(i))
                {
                    checkPrimes.Add(i);
                }
            }
            return checkPrimes;
        }
    }
}
