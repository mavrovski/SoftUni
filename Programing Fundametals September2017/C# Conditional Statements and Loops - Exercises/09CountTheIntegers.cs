using System;

namespace _09CountTheIntegers
{
    public class _09CountTheIntegers
    {
        public static void Main(string[] args)
        {
            var input="";
            int output;
            int counter = 0;

            bool isInt;
            do
            {
                input = Console.ReadLine();
                isInt = Int32.TryParse(input, out output);
                counter++;
            } while (isInt);
            Console.WriteLine(counter-1);
        }
    }
}
