using System;

namespace _09MultiplicationTable
{
    public class _09MultiplicationTable
    {
        public static void Main(string[] args)
        {
            int multiplicationNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{multiplicationNumber} X {i} = {multiplicationNumber*i}");
            }

        }
    }
}
