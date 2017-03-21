using System;

public class Program
{
	public static void Main()
	{

	var Product = Console.ReadLine().ToLower();
	var City = Console.ReadLine().ToLower();
	var Quanity = double.Parse(Console.ReadLine());

	if(City == "sofia")
		{
		if (Product == "coffee")Console.WriteLine(0.5* Quanity);
		else if (Product == "water")Console.WriteLine(0.8* Quanity);
		else if (Product == "beer")Console.WriteLine(1.2* Quanity);
		else if (Product == "sweets")Console.WriteLine(1.45* Quanity);
		else if (Product == "peanuts")Console.WriteLine(1.6* Quanity);
		}
	if(City == "plovdiv")
		{
		if (Product == "coffee")Console.WriteLine(0.4* Quanity);
		else if (Product == "water")Console.WriteLine(0.7* Quanity);
		else if (Product == "beer")Console.WriteLine(1.15* Quanity);
		else if (Product == "sweets")Console.WriteLine(1.30* Quanity);
		else if (Product == "peanuts")Console.WriteLine(1.50* Quanity);
		}
		if(City == "varna")
		{
		if (Product == "coffee")Console.WriteLine(0.45* Quanity);
		else if (Product == "water")Console.WriteLine(0.7* Quanity);
		else if (Product == "beer")Console.WriteLine(1.10* Quanity);
		else if (Product == "sweets")Console.WriteLine(1.35* Quanity);
		else if (Product == "peanuts")Console.WriteLine(1.55* Quanity);
		}
	}
}
