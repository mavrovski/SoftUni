using System;
using System.Linq;

namespace _04TripleSum
{
    public class _04TripleSum
    {
        public static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ')
                .Select(long.Parse)
                .ToArray();
            bool match = false;
            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = a+1; b < numbers.Length; b++)
                {
                    long sum = numbers[a] + numbers[b];
                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{numbers[a]} + {numbers[b]} == {sum}");
                        match = true;
                    }

                }
            }
            if (!match)
            {
                Console.WriteLine("No");
            }

        }
    }
}
