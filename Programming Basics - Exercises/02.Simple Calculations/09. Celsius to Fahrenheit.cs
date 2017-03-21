using System;

public class Program
{
	public static void Main()
	{
		var degreeCelsus = double.Parse(Console.ReadLine());
		var Farenheit = degreeCelsus*1.8+32;
		Console.WriteLine(Math.Round(Farenheit,2));

	}
}
