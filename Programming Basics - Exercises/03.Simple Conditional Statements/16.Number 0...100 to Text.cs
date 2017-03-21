using System;

public class Program
{
	public static void Main()
	{
		    int num = int.Parse(Console.ReadLine());
            string[] toNineteen = { "zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] toNinety = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            if (num < 0 )
            {
                Console.WriteLine("Invalid number");
            }
            else if (num > 100)
            {
                Console.WriteLine("Invalid number");
            }
            else if (num>=0 && num <= 19)
            {
                Console.WriteLine(toNineteen[num]);
            }
            else if (num>=20 && num < 100)
            {
                if (num%10 == 0)
                {
                    Console.WriteLine(toNinety[(num / 10) - 2]);
                }
                else
                {
                    Console.WriteLine(toNinety[(num / 10) - 2] +" "+ toNineteen[(num % 10)]);

                }
            }
            else if (num == 100)
            {
                Console.WriteLine("one hundred");
            }
	}
}
