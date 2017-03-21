using System;

public class Program
{
	public static void Main()
	{
		var x1 = double.Parse(Console.ReadLine());
		var y1 = double.Parse(Console.ReadLine());
		var x2 = double.Parse(Console.ReadLine());
		var y2 = double.Parse(Console.ReadLine());

		var a = Math.Max(x1,x2)-Math.Min(x1,x2);
		var b = Math.Max(y1,y2)-Math.Min(y1,y2);

		var area = a*b;

		var perimetar = (2*a) + (2*b);

		Console.WriteLine(area);
		Console.WriteLine(perimetar);
	}
}
