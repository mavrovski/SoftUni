using System;

public class Program
{
	public static void Main()
	{
		var countRadians = double.Parse(Console.ReadLine());
		var totalDegrees = (countRadians*180)/Math.PI;
		Console.WriteLine(Math.Round(totalDegrees,2));
	}
	
}
