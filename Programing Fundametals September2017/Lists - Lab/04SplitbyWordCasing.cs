using System;
using System.Collections.Generic;
using System.Linq;

namespace _04SplitbyWordCasing
{
    public class _04SplitbyWordCasing
    {
        public static void Main(string[] args)
        {
            char[] separator = { ',', ';', ':', '.', '!', '(', '(', ')', '"', '\\', '/', '[', ']' ,' ','\''};
            List<string> text = Console.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                bool hasAllUpC = true;
                bool hasAllLowC = true;
                foreach (char word in text[i])
                {
                    if (char.IsUpper(word))
                    {
                        hasAllLowC = false;
                    }
                    else if (char.IsLower(word))
                    {
                        hasAllUpC = false;
                    }
                    else
                    {
                        hasAllLowC = false;
                        hasAllUpC = false;
                    }
                }
                if (hasAllUpC == true && hasAllLowC == false)
                {
                    upperCase.Add(text[i]);
                }
                else if (hasAllUpC == false && hasAllLowC == true)
                {
                    lowerCase.Add(text[i]);
                }
                else if (hasAllUpC == false && hasAllLowC == false)
                {
                    mixedCase.Add(text[i]);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase).TrimEnd(new char[] { ' ', ',' }));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase).TrimEnd(new char[] { ' ', ',' }));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase).TrimEnd(new char[] { ' ', ',' }));


        }
    }
}
