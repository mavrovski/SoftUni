using System;

namespace _05WordinPlural
{
    public class _05WordinPlural
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine();
            var charOne = word[word.Length - 1];
            var charTwo = word[word.Length - 2];

            if (charOne == 'y')
            {
                word = word.Remove(word.Length - 1); 
                Console.WriteLine(word+ "ies");
            }
            else if (charOne == 'o' || charOne=='s'||charOne=='x'||charOne=='z'|| (charOne=='h' && charTwo == 'c'||charTwo=='s'))
            {
                Console.WriteLine(word+"es");
            }
            else
            {
                Console.WriteLine(word + "s");
            }

        }
    }
}
