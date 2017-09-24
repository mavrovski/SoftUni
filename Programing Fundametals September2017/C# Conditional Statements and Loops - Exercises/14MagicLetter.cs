using System;

namespace _14.MagicLetter
{
    public class _14MagicLetter
    {
        public static void Main(string[] args)
        {
            var firstChar = char.Parse(Console.ReadLine());
            var secondChar = char.Parse(Console.ReadLine());
            var invalidChar = char.Parse(Console.ReadLine());

            for (char i = firstChar; i <= secondChar; i++)
            {
                for (char j = firstChar; j <= secondChar; j++)
                {
                    for (char k = firstChar; k <= secondChar; k++)
                    {
                        if (i != invalidChar && j != invalidChar && k != invalidChar)
                        {
                            Console.Write("{0}{1}{2} ",i,j,k);
                        }
                    }
                }
                
            }

        }
    }
}
