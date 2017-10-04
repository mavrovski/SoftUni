using System;

namespace _09ReversedChars
{
    public class _09ReversedChars
    {
        public static void Main(string[] args)
        {
           
            string charOne = Console.ReadLine();
            string charTwo = Console.ReadLine();
            string charThree = Console.ReadLine();

            string allChar = charOne + charTwo + charThree;
            string conertChars = " ";
            for (int i = allChar.Length-1; i >=0 ; i--)
            {
                conertChars += allChar[i];
            }
            Console.WriteLine(conertChars);
        }
    }
}
