using System;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		var num = 1;
		Console.WriteLine(num);


		for(int i = 0;i<n;i++)
		{
		num *=2;
		Console.WriteLine(num);
		}
	}
	
}
