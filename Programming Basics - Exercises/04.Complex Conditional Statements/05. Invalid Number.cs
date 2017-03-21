using System;

public class Program
{
	public static void Main()
	{
		double num = double.Parse(Console.ReadLine());

		if (!(num == 0 || num >= 100 && num <=200 ))
		{
		Console.WriteLine("invalid");
		}

	}
}
