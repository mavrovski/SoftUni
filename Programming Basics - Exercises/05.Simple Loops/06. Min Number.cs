using System;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int min = 0;

		for(int i = 0; i < n; i++)
		{

		int num = int.Parse(Console.ReadLine());
			if(num < min)
			{
			min = num;
			}
			if (i == 0)
			{
			min = num;
			}

		}
		Console.WriteLine(min);
	}
}
