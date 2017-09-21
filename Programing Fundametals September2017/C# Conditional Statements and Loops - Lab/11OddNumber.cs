using System;

namespace _11OddNumber
{
    public class _11OddNumber
    {
        public static void Main(string[] args)
        {

            int oddNumber;
            bool isEven;
            do
            {
                oddNumber = int.Parse(Console.ReadLine());
                isEven = oddNumber % 2 == 0;
                if (isEven)
                {
                    Console.WriteLine("Please write an odd number.");
                }

            }
            while (isEven);
            Console.WriteLine("The number is: {0}", Math.Abs(oddNumber));

            //##SECOND WAY 
            //int n;
            //bool isEven = true;
            //while (isEven)
            //{
            //    n= int.Parse(Console.ReadLine());
            //    if (n %2 == 0)
            //    {
            //        Console.WriteLine("Please write an odd number.");
            //        n = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Please write an odd number.");
            //    }
            //    else
            //    {
            //        isEven = false;
            //        Console.WriteLine("The number is: {0}", Math.Abs(n));
            //    }
            //}

        }
    }
}
