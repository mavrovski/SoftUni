using System;

namespace _10MultiplicationTable2
{
    public class _10MultiplicationTable2
    {
        public static void Main(string[] args)
        {

            int multiplicationNumber = int.Parse(Console.ReadLine());
            int multiplicator = int.Parse(Console.ReadLine());

            if (multiplicator > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", multiplicationNumber, multiplicator, multiplicationNumber * multiplicator);
            }
            else
            {
                for (int i = multiplicator; i <= 10; i++)
                {
                    Console.WriteLine($"{multiplicationNumber} X {i} = {multiplicationNumber * i}");

                }
            }


        }

    }
}
