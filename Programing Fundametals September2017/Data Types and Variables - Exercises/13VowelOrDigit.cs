using System;

namespace _13VowelOrDigit
{
    public class _13VowelOrDigit
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result;
            bool isDigit= Int32.TryParse(input, out result);


            if (input == "a" || input == "u" || input == "e" || input == "i" || input == "y" || input == "o")
            {
                Console.WriteLine("vowel");
            }
            else if (isDigit)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
