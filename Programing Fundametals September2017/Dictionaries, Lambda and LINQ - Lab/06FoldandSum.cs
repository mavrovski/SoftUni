using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FoldandSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var firstFoldetNumbers = numbers
                .Take(numbers.Length / 4)
                .Reverse()
                .ToList();

            var middleNumbers = numbers
                .Skip(numbers.Length / 4)
                .Take(2 * numbers.Length / 4)
                .ToList();

            var secondFoldetNumber = numbers
                .Skip(3*numbers.Length / 4)
                .Take(numbers.Length/4)
                .Reverse()
                .ToList();

            var foldedSum = new List<int>();
            foldedSum.AddRange(firstFoldetNumbers);
            foldedSum.AddRange(secondFoldetNumber);

            var summed = new List<int>();

            for (int i = 0; i < middleNumbers.Count; i++)
            {
                summed.Add(foldedSum[i] + middleNumbers[i]);
            }

            Console.WriteLine(string.Join(" ", summed));

        }
    }
}
