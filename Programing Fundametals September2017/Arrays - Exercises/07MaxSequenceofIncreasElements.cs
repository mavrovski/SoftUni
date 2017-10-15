using System;
using System.Linq;

namespace _07MaxSequenceofIncreasElements
{
    public class _07MaxSequenceofIncreasElements
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var counter = 1;
            var bestCounter = 0;
            var bestStart = 0;

            for (int i = numbers.Length-1; i > 0; i--)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (bestCounter<=counter)
                {
                    bestStart = i - 1;
                    bestCounter = counter;
                }
            }
            for (int i = bestStart; i < bestStart+bestCounter; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            

        }
    }
}
