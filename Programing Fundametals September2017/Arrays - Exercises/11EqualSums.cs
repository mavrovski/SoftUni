using System;
using System.Linq;

namespace _11EqualSums
{
    public class _11EqualSums
    {
        public static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            for (int i = 0; i < elements.Length; i++)
            {
                var leftSum = 0;
                var rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += elements[j];

                }
                for (int j = i+1; j < elements.Length; j++)
                {
                    rightSum += elements[j];
                }
                if (leftSum==rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
