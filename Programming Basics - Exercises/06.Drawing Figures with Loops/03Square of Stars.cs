using System;

public class Program
{
	public static void Main()
	{
		var n = int.Parse(Console.ReadLine());


		for(int i = 1;i <= n;i++)
		{
		Console.Write("*");
			for(int c = 1; c<n;c++)
			{
			Console.Write(" *");
			}
		Console.WriteLine();

		}
	}
}
