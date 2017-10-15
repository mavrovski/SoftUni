using System;
using System.Collections.Generic;
using System.Linq;

namespace _01MaxSequenceofEqualElements
{
    public class _01MaxSequenceofEqualElements
    {
        public static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            
            int start = 0;
            int len = 1;

            int bestPosition = 0;
            int bestLen = 1;

            for (int i = 1; i < elements.Count; i++)
            {
                if (elements[i] == elements[i - 1])
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestPosition = start;
                    }
                }
                else
                {
                    if (len > bestLen)
                    {
                        bestPosition = start;
                        bestLen = len;
                    }
                    start = i;
                    len = 1;
                }
            }

            for (int i = bestPosition; i < bestPosition + bestLen; i++)
            {
                Console.Write($"{elements[i]} ");
            }

        }
    }
}
