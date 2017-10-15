using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03SearchforaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInts = Console.ReadLine()
                     .Split(' ')
                     .Select(int.Parse)
                     .ToList();
            int[] threeNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            List<int> results = new List<int>();
            var numberOfElementsToTake = threeNumbers[0];
            var numberOfElementsToDelete = threeNumbers[1];
            var numberForSearch = threeNumbers[2];
            for (int i = 0; i < numberOfElementsToTake; i++)
            {
                results.Add(listOfInts[i]);
            }
            results.RemoveRange(0, numberOfElementsToDelete);
            if (results.Contains(numberForSearch))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
