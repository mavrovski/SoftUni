using System;

public class Program
{
	public static void Main()
	{
		  double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = a * h / 2;
            Math.Round(area, 2);
            Console.WriteLine("Triangle area = {0:F2}", area);
	}
}
