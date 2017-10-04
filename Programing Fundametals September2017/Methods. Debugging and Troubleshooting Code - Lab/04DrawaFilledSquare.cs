using System;

namespace _04DrawaFilledSquare
{
    public class _04DrawaFilledSquare
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSquare(n);

        }



        private static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-' , 2*n));
        }
        private static void PrintMiddleRow(int n)
        {
            for (int j = 0; j < n - 2; j++)
            {
                Console.Write("-");
                for (int i = 0; i < n - 1; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
        private static void PrintSquare(int n)
        {
            PrintHeaderRow(n);
            PrintMiddleRow(n);
            PrintHeaderRow(n);

        }
    }
}
