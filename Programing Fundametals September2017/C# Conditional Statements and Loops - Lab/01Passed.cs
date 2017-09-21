using System;

namespace _01Passed
{
    public class _01Passed
    {
        public static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade>=3)
            {
                Console.WriteLine("Passed!");
            } 
        }
    }
}
