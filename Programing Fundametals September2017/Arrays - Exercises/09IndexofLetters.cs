using System;

namespace _09IndexofLetters
{
    public class _09IndexofLetters
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            char[] alphabet = new char[] { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        Console.WriteLine("{0} -> {1}", word[i], j);
                    }
                }
               
            }

        }
    }
}
