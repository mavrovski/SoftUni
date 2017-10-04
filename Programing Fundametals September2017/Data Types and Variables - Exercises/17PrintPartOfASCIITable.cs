using System;

namespace _17PrintPartOfASCIITable
{
    public class _17PrintPartOfASCIITable
    {
        public static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int stopIndex = int.Parse(Console.ReadLine());


            for (int i = startIndex; i <= stopIndex; i++)
            {
                Console.Write("{0} ",(char)i);
            }
        }
    }
}
