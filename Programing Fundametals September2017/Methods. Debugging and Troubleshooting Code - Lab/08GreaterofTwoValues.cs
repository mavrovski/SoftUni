using System;

namespace _08GreaterofTwoValues
{
    public class _08GreaterofTwoValues
    {
        public static void Main(string[] args)
        {

            var type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    int max = GetMax(first, second);
                    Console.WriteLine(max);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    char maxChar = GetMax(firstChar, secondChar);
                    Console.WriteLine(maxChar);
                    break;

                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string maxString = GetMax(firstString, secondString);
                    Console.WriteLine(maxString);
                    break;
                default:
                    break;
            }

          
        }

        public static char GetMax(char first, char second)
        {
            char check;
            if (first >= second)
            {
                check = first;
            }
            else
            {

                check = second;
            }

            return check;
        }
        public static int GetMax(int first, int second)
        {
            int check = 0;
            if (first >= second)
            {
                check = first;
            }
            else
            {

                check = second;
            }

            return check;
        }
        public static string GetMax(string first, string second)
        {
            string check = "a";
            if (first.CompareTo(second) >= 0)
            {
                check = first;
            }
            else if (second.CompareTo(first) >= 0)
            {

                check = second;
            }
            else if (second.CompareTo(first) == 0)
            {
                check = second;
            }
            return check;
        }
    }
}
