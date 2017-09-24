using System;

namespace _05WordinPlural2
{
    public class _05WordinPlural2
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine();
           

            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                Console.WriteLine(word + "ies");
            }
            else if (word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z") 
                    || word.EndsWith("h")|| word.EndsWith("ch")|| word.EndsWith("sh"))
            {
                Console.WriteLine(word + "es");
            }
            else
            {
                Console.WriteLine(word + "s");
            }

        }
    }
}
