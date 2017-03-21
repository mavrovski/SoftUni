using System;

public class Program
{
	public static void Main()
	{

		var smallerRoom = double.Parse(Console.ReadLine());
		var kichenSize = double.Parse(Console.ReadLine());
		var Price = double.Parse(Console.ReadLine());

		var Bath = smallerRoom/2;
		var secondRoom = smallerRoom+smallerRoom*0.1;
		var thirdRoom = secondRoom+secondRoom*0.1;
		var All= smallerRoom+kichenSize+Bath+secondRoom+thirdRoom;
		var allFloor = All+All*0.05;
		var appPrice= allFloor*Price;
		Console.WriteLine("{0:F2}",appPrice);
	}

}
