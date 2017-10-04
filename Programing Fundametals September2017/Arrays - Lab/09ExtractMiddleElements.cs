using System;
using System.Linq;

namespace _09ExtractMiddleElements
{
    public class _09ExtractMiddleElements
    {
        public static void Main(string[] args)
        {
            int[] elements = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int length = elements.Length;

            if (length == 1)
            {
                Console.WriteLine($"{{ {elements[0]} }}");
            }
            else if (length % 2 == 0)
            {
                Console.WriteLine($"{{ {elements[length / 2 - 1]}, {elements[(length / 2)]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {elements[length / 2 - 1]}, {elements[length / 2]}, {elements[length / 2 + 1]} }}");
            }

        }
    }
}
