using System;

namespace _03PrintingTriangle
{
    public class _03PrintingTriangle
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                PrintLine(1,i);

            }
            for (int i = n; i >=0 ; i--)
            {
                PrintLine(1, i);
            }

        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

    }
}
