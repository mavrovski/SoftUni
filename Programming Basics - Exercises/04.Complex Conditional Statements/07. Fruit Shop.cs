using System;

public class Program
{
	public static void Main()
	{
		var Fruit = Console.ReadLine().ToLower();
		var Day = Console.ReadLine().ToLower();
		var quantity = double.Parse(Console.ReadLine());
		var price = -1.0;

		if(Day == "monday" || Day == "tuesday" || Day == "wednesday" || Day == "thursday" || Day == "friday")

		{
			if(Fruit=="banana") price = 2.50;
 			else if(Fruit=="apple") price = 1.20;
			else if(Fruit=="orange") price = 0.85;
			else if(Fruit=="grapefruit") price = 1.45;
			else if(Fruit=="kiwi") price = 2.70;
			else if(Fruit=="pineapple") price = 5.50;
			else if(Fruit=="grapes") price = 3.85;


		}
		else if(Day == "saturday" || Day == "sunday" )
		{
		if(Fruit=="banana") price = 2.70;
 			else if(Fruit=="apple") price = 1.25;
			else if(Fruit=="orange") price = 0.90;
			else if(Fruit=="grapefruit") price = 1.60;
			else if(Fruit=="kiwi") price = 3.00;
			else if(Fruit=="pineapple") price = 5.60;
			else if(Fruit=="grapes") price = 4.20;


		}
		if(price >=0) Console.WriteLine("{0:f2}",price*quantity);
		else Console.WriteLine("error");
	}
}
