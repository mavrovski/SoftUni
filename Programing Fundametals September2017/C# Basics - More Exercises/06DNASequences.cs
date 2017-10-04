using System;

namespace _06DNASequences
{
    public class _06DNASequences
    {
        public static void Main(string[] args)
        {
            int matchSum = int.Parse(Console.ReadLine());
            var sum = 0;
            char startEndSymbol = ' ';
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        sum = i + j + k;
                        if (sum>=matchSum)
                        {
                            startEndSymbol = 'O';

                        }
                        else
                        {
                            startEndSymbol = 'X';
                        }
                        Console.Write("{0}{1}{2}{3}{0} ",startEndSymbol,GetSymbol(i),GetSymbol(j),GetSymbol(k));

                    }
                    Console.WriteLine();
                }
            }
            
             

        }
        static char GetSymbol(int number)
        {
            char symbol = ' ';
            switch (number)
            {
                case 1:
                    symbol = 'A';
                    break;
                case 2:
                    symbol = 'C';
                    break;
                case 3:
                    symbol = 'G';
                    break;
                case 4:
                    symbol = 'T';
                    break;

                default:
                    break;
            }
            return symbol;
        } 
    }
}
