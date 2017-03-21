using System;

public class Program
{
	public static void Main()
	{
		double Speed = double.Parse(Console.ReadLine());


		if(Speed <= 10)
		{
		Console.WriteLine("slow");
		}
		else if(Speed > 10 && Speed <=50)
		{
		Console.WriteLine("average");
		}
		else if(Speed > 50 && Speed <=150)
		{
		Console.WriteLine("fast");
		}
		else if(Speed > 150 && Speed <=1000)
		{
		Console.WriteLine("ultra fast");
		}
		else
		{
		Console.WriteLine("extremely fast");
		}

	}
}
