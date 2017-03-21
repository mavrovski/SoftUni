using System;

public class Program
{
	public static void Main()
	{
		var skumriaValue = double.Parse(Console.ReadLine());
		var cacaValue = double.Parse(Console.ReadLine());

		var palamudValue = double.Parse(Console.ReadLine());
		var SafridValue = double.Parse(Console.ReadLine());
		var midiValue = double.Parse(Console.ReadLine());


		var PricePalamud = skumriaValue+skumriaValue*0.60;
		var PalamundSum = PricePalamud*palamudValue;
		var PriceSafrid = cacaValue+cacaValue*0.8;
		var SafridSum = PriceSafrid*SafridValue;
		var PriceMidi = midiValue*7.50;
		var Sum = PalamundSum+SafridSum +PriceMidi;
		Console.WriteLine("{0:F2}",Sum);

	}
}
