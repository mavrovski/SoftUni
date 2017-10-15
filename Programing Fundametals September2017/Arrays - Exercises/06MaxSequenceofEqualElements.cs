using System;
using System.Linq;

namespace _06MaxSequenceofEqualElements
{
    public class _06MaxSequenceofEqualElements
    {
        public static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var startIndex = 0;
            var sequanceLenght = 1;

            var bestStartIndex = 0;
            var bestSequanceLenght = 0;
            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] == arr[i - 1])
                {
                    sequanceLenght++;
                    if (sequanceLenght > bestSequanceLenght)
                    {
                        bestStartIndex = startIndex;
                        bestSequanceLenght = sequanceLenght;

                    }
                }
                else
                {
                    startIndex = i;
                    sequanceLenght = 1;
                }

            }
            for (int i = bestStartIndex; i < bestStartIndex + bestSequanceLenght; i++)
            {
                Console.Write(arr[i] + " ");
            }
            

        }
    }
}
