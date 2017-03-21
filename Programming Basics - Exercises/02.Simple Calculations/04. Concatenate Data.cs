using System;

public class Program
{
	public static void Main()
	{

		var name = Console.ReadLine();
		var lastName = Console.ReadLine();
		var age = int.Parse(Console.ReadLine());
		var city = Console.ReadLine();
		Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.",name,lastName,age,city);

	}
}
