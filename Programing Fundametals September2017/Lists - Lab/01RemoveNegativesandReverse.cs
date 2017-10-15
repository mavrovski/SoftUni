using System;
using System.Collections.Generic;
using System.Linq;
namespace _01RemoveNegativesandReverse
{
    public class _01RemoveNegativesandReverse
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(a =>int.Parse(a)).ToArray();

            List<int> removeNegatives = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>=0)
                {
                    removeNegatives.Add(numbers[i]);
                }
            }
            if (removeNegatives.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                removeNegatives.Reverse();
                foreach (var num in removeNegatives)
                {
                    Console.Write(num + " ");
                }
            }
            
        }
    }
}
