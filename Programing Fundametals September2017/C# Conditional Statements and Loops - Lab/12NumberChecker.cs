using System;

namespace _12NumberChecker
{
    public class _12NumberChecker
    {
        public static void Main(string[] args)
        {
           

            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid input!");
            }

        }
    }
}
