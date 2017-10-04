using System;
using System.Linq;

namespace _07SumArrays
{
    public class _07SumArrays
    {
        public static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int len1 = arrayOne.Length;
            int len2 = arrayTwo.Length;
            int maxLenght = Math.Max(len1,len2);
            int[] sum = new int[maxLenght];
            for (int i = 0; i < maxLenght; i++)
            {
                sum[i] = arrayOne[i % len1] + arrayTwo[i % len2];
            }
            foreach (var num in sum)
            {
                Console.Write("{0} ",num);
            }
        }
    }
}
