using System;

namespace _13GameofNumbers
{
    public class _13GameofNumbers
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            var sum = 0;
            var counter = 0;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    sum = i + j;
                    counter++;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {sum}");
                        return;
                    }

                }
            }
            if (sum != magicNumber)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }

        }
    }
}
