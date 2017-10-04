using System;
using System.Linq;

namespace _06ReverseArrayofStrings
{
    public class _06ReverseArrayofStrings
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            for (int i = words.Length-1; i >= 0; i--)
            {
                Console.Write("{0} ",words[i]);
            }

        }
    }
}
