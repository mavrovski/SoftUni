using System;

namespace _06TriplesOfLetters
{
    public class _06TriplesOfLetters
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char letters = (char)('a' + n);
            for (char i = 'a'; i < letters; i++)
            {
                for (char j = 'a'; j < letters; j++)
                {
                    for (char k = 'a'; k < letters; k++)
                    {
                        Console.WriteLine("{0}{1}{2}",i,j,k);
                    }
                }
            }

        }
    }
}
