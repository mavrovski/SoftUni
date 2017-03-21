using System;

public class Program
{
	public static void Main()
	{
	string typeTicket = Console.ReadLine().ToLower();
	var Rows = double.Parse(Console.ReadLine());
	var Columns = double.Parse(Console.ReadLine());
	var Sum = 0.00;

	switch(typeTicket)
	{
	case "premiere":
	Sum = Rows*Columns*12.00;
	break;
	case "normal":
	Sum = Rows*Columns*7.50;
	break;
	case "discount":
	Sum = Rows*Columns*5;
	break;

	}
		Console.WriteLine("{0:f2} leva",Sum);
	}
}
