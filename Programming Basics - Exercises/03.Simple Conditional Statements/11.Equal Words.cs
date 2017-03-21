using System;

public class Program
{
	public static void Main()
	{
		string Word1 = Console.ReadLine();
		string Word2 = Console.ReadLine();

		Word1 = Word1.ToLower();
		Word2 = Word2.ToLower();

		if (Word1 == Word2)
		{


		Console.WriteLine("yes");
		}

		else
		{
		Console.WriteLine("no");

		}

	}
}
