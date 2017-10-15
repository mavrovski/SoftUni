using System;
using System.Linq;

namespace _05CompareCharArrays
{
    public class _05CompareCharArrays
    {
        public static void Main(string[] args)
        {
            

            char[] arrayOne = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arrayTwo = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int arrayOneLenght = arrayOne.Length;
            int arrayTwoLenght = arrayTwo.Length;

            int shortestArray = Math.Min(arrayOneLenght, arrayTwoLenght);

            for (int i = 0; i < shortestArray; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    if (arrayOne[i] < arrayTwo[i])
                    {
                        Console.WriteLine(String.Join("", arrayOne));
                        Console.WriteLine(String.Join("", arrayTwo));
                        return;
                    }
                    else
                    {
                        Console.WriteLine(String.Join("", arrayTwo));
                        Console.WriteLine(String.Join("", arrayOne));
                        return;
                    }
                }
            }
            if (arrayOneLenght < arrayTwoLenght)
            {
                Console.WriteLine(String.Join("", arrayOne));
                Console.WriteLine(String.Join("", arrayTwo));
            }
            else
            {
                Console.WriteLine(String.Join("", arrayTwo));
                Console.WriteLine(String.Join("", arrayOne));
            }


        }
    }
}
