using System;

public class Program
{
	public static void Main()
	{
		 Console.Write(" r = ");
double r = double.Parse(Console.ReadLine());

double p = (2 * Math.PI) * r;
double a = (Math.PI * (r * r));


Console.WriteLine("Area is : {0:f2}" , a);
Console.WriteLine("Perimeter is : {0:f2}", p);

	}
}
