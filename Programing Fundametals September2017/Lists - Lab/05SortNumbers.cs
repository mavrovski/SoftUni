using System;
using System.Linq;

namespace _05SortNumbers
{
    public class _05SortNumbers
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            numbers.Sort();
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
