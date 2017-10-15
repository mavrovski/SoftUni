using System;
using System.Linq;

namespace _02RotateandSum
{
    public class _02RotateandSum
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int rotateTimes = int.Parse(Console.ReadLine());
           
            var sumNumbers = new int[numbers.Length];

            for (int i = 0; i < rotateTimes; i++)
            {
                RotateArray(numbers);
                for (int j = 0; j < numbers.Length; j++)
                {
                    sumNumbers[j] += numbers[j];
                }
              
            }
             Console.WriteLine(string.Join(" ", sumNumbers));
        

        }
        static void RotateArray(int[] arr)
        {
            var lastElement = arr[arr.Length - 1];
            for (int i = arr.Length-1; i >0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = lastElement;
        }
    }
}
