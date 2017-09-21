using System;

namespace _02PassedorFailed
{
    public class _02PassedorFailed
    {
        public static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade>=3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }


        }
    }
}
