using System;

public class Program
{
	public static void Main()
	{
		double numOne = double.Parse(Console.ReadLine());
		double numTwo = double.Parse(Console.ReadLine());
		double numThree = double.Parse(Console.ReadLine());

		if(numOne == numTwo && numTwo == numThree)
		{
		Console.WriteLine("yes");
		}
		else
		{
		Console.WriteLine("no");
		}
	}
}
