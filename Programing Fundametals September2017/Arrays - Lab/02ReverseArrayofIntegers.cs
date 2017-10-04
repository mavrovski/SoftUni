using System;

namespace _02ReverseArrayofIntegers
{
    public class _02ReverseArrayofIntegers
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var integers=new int[n];

            for (int i = 0; i < n; i++)
            {
                integers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = integers.Length-1; i >= 0; i--)
            {
                Console.WriteLine(integers[i] + " ");
                Console.WriteLine();
            }
        }
    }
}
