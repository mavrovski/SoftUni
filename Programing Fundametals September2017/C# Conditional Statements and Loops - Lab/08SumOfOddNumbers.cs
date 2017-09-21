using System;

namespace _08SumOfOddNumbers
{
    public class _08SumOfOddNumbers
    {
        public static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 1; i <= num*2; i+=2)
            {   
                Console.WriteLine("{0}",i);
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
