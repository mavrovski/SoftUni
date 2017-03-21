using System;

public class Program
{
	public static void Main()
	{
		double Number = double.Parse(Console.ReadLine());

		if (Number < 100)
		{
		Console.WriteLine("Less than 100");
		}
		else if (Number >= 100 && Number <= 200)
		{
		Console.WriteLine("Between 100 and 200");
		}
		else if (Number > 200)
		{
		Console.WriteLine("Greater than 200");
		}
	}
}
