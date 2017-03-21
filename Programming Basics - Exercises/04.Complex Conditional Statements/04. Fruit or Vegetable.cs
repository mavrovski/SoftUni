using System;

public class Program
{
	public static void Main()
	{

		string Input = Console.ReadLine().ToLower();

		if (Input == "banana" || Input == "apple" || Input == "kiwi" || Input == "cherry"|| Input == "lemon" || Input == "grapes")
		{
		Console.WriteLine("fruit");
		}
		else if (Input == "tomato"|| Input == "cucumber" || Input == "pepper" || Input == "carrot")
		{
		Console.WriteLine("vegetable");
		}
		else Console.WriteLine("unknown");

	}
}
