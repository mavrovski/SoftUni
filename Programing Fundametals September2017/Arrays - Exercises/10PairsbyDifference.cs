using System;
using System.Linq;

namespace _10PairsbyDifference
{
    public class _10PairsbyDifference
    {
        public static void Main(string[] args)
        {
            var sequenceOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = sequenceOfNumbers.Length-1;  i>=0;  i--)
            {
                for (int j = sequenceOfNumbers.Length-1; j >= 0; j--)
                {
                    if (sequenceOfNumbers[i]-sequenceOfNumbers[j]==difference)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
