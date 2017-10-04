using System;

namespace _12MasterNumber
{
    public class _12MasterNumber
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (IsPalindrome(i)&&IsContainsEvenDigit(i))
                {
                    if (SumOfDigits(i)%7==0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        private static bool IsContainsEvenDigit(int num)
        {
            bool IsContainsEvenDigit = false;
            int digit = 0;
            while (num > 0)
            {
                digit = num % 10;
                num /= 10;
                if (digit % 2 == 0)
                {
                    IsContainsEvenDigit = true;
                }
            }
            return IsContainsEvenDigit;
        }
        private static int SumOfDigits(int num)
        {
            
            int result = 0;
            while (num > 0)
            {
                result += num % 10;
                num /= 10;
            }
            return result;
        }

        private static bool IsPalindrome(int num)
        {
            int numBefore = num;
            bool IsPalindrome = false;
            int digit = 0;
            int reverse = 0;
            while (num > 0)
            {
                digit = num % 10;
                reverse = reverse * 10 + digit;
                num /= 10;
            }
            if (numBefore == reverse)
            {
                IsPalindrome = true;
            }
            else
            {
                IsPalindrome = false;
            }
            return IsPalindrome;
        }
    }
}
