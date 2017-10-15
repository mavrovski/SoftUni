using System;
using System.Collections.Generic;
using System.Linq;

namespace _06SquareNumbers
{
    public class _06SquareNumbers
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> results = new List<int>();

            foreach (var numb in numbers)
            {
                if (Math.Sqrt(numb)== (int)Math.Sqrt(numb))
                {
                    results.Add(numb);
                }
            }
           // results.Sort((a,b) => b.CompareTo(a));
            results.Sort();
            results.Reverse();
            Console.WriteLine(String.Join(" ",results));
        }
    }
}
