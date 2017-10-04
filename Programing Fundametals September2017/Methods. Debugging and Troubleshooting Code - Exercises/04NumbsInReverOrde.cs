using System;

namespace _04NumbsInReverOrde
{
    public class _04NumbsInReverOrde
    {
        public static void Main(string[] args)
        {
            string number = Console.ReadLine();
            var result = NumbersinReversedOrder(number);
            Console.WriteLine(result);
        }

        private static string NumbersinReversedOrder(string number)
        {
            string reverseNumber = "";

            for (int i = number.Length-1; i >= 0; i--)
            {
                reverseNumber += number[i];
            }
            return reverseNumber;
        }
    }
}
