using System;
using System.Linq;

namespace _03FoldandSum
{
    public class _03FoldandSum
    {
        public static void Main(string[] args)
        {
            var elements = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var k = elements.Length / 4;
            var leftArray = new int[k];
            var middleArray = new int[k*2];
            var rightArray = new int[k];
            var sumArray = new int[2*k];
            for (int i = 0; i < k; i++)
            {
                leftArray[i] = elements[i];
                rightArray[i] = elements[k * 3 + i];
            }
            
            for (int i = 0; i < k*2; i++)
            {
                middleArray[i] = elements[k+i];
            }
            Array.Reverse(leftArray);
            Array.Reverse(rightArray);
            for (int i = 0; i < k; i++)
            {
                sumArray[i] += middleArray[i] + leftArray[i];
                sumArray[i + k] = middleArray[i + k] + rightArray[i];
            }
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
