using System;

namespace _02SignofIntegerNumb
{
    public class _02SignofIntegerNumb
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);

        }

        private static void PrintSign(int number)
        {
            if (number>0)
            {
                Console.WriteLine("The number {0} is positive.",number);
            }
            else if (number<0)
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.",number);
            }
        }
    }
}
