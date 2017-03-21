using System;

public class Program
{
	public static void Main()
	{
		var USD = double.Parse(Console.ReadLine());
		var toLeva = USD*1.79549;
		Console.WriteLine(Math.Round(toLeva,2));

	}
}
