using System;

public class Program
{
	public static void Main()
	{
		var magnolias = int.Parse(Console.ReadLine());
		var hyacinths = int.Parse(Console.ReadLine());
		var roses = int.Parse(Console.ReadLine());
		var cactus = int.Parse(Console.ReadLine());
		var giftPrice = double.Parse(Console.ReadLine());

		var sum = magnolies*3.25+zumbuls*4.00+roses*3.5+ cactus*8.00;
		var sumAtaxes=sum-sum*0.05;

		if(giftPrice<=sumAtaxes)
		{
			Console.WriteLine("She is left with {0} leva.",Math.Floor((sumAtaxes-giftPrice)));

		}
		else{

			Console.WriteLine("She will have to borrow {0} leva." ,Math.Ceiling((giftPrice-sumAtaxes)));
		}

	}
}
