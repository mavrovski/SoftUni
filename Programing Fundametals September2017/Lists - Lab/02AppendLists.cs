using System;
using System.Collections.Generic;
using System.Linq;

namespace _02AppendLists
{
    public class _02AppendLists
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split('|').ToArray();

            List<int> reverse = new List<int>();
            for (int i = numbers.Length-1; i >=0; i--)
            {
                List<int>nums = numbers[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                foreach (var num in nums)
                {
                    reverse.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ",reverse));
        }
    }
}
