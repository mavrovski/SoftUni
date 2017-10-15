using System;
using System.Linq;

namespace _01LargestCommonEnd
{
    public class _01LargestCommonEnd
    {
        public static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split(' ').ToArray();
            string[] arrayTwo = Console.ReadLine().Split(' ').ToArray();

            int arrayOneCount = 0;
            int arrayTwoCount = 0;

            var smallerArrayLenght = Math.Min(arrayOne.Length, arrayTwo.Length);

            for (int i = 0; i < smallerArrayLenght; i++)
            {
                if (arrayOne[i] == arrayTwo[i])
                {
                    arrayOneCount++;
                }
                if (arrayOne[arrayOne.Length-1-i]==arrayTwo[arrayTwo.Length-1-i])
                {
                    arrayTwoCount++;
                }
            }
            Console.WriteLine(Math.Max(arrayOneCount,arrayTwoCount)); 
        }
    }
}
