using System;

namespace _03EngNameLastDigit
{
    public class _03EngNameLastDigit
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            EnglishNameOfLastDigit(number);

        }

        private static void EnglishNameOfLastDigit(long number)
        {

           
            long lastNumber = Math.Abs(number % 10);
            string englishName = "";
            switch (lastNumber)
            {
                case 0:
                    englishName = "zero";
                    break;
                case 1:
                    englishName = "one";
                    break;
                case 2:
                    englishName = "two";
                    break;
                case 3:
                    englishName = "three";
                    break;
                case 4:
                    englishName = "four";
                    break;
                case 5:
                    englishName = "five";
                    break;
                case 6:
                    englishName = "six";
                    break;
                case 7:
                    englishName = "seven";
                    break;
                case 8:
                    englishName = "eight";
                    break;
                case 9:
                    englishName = "nine";
                    break;
                default:
                    break;
            }
            Console.WriteLine(englishName);
            
        }
    }
}
