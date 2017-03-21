using System;

public class Program
{
	public static void Main()
	{
		int firstPlayer = int.Parse(Console.ReadLine());
		int secondPlayer = int.Parse(Console.ReadLine());
		int thirdPlayer = int.Parse(Console.ReadLine());
		int Sum = firstPlayer+secondPlayer+thirdPlayer;
		int Minutes = Sum/60;
		int Seconds = Sum-(Minutes*60);

		if(Seconds < 10)
		{


		Console.WriteLine(Minutes+":"+"0"+Seconds);


		}
		else
		{


		Console.WriteLine(Minutes+":"+Seconds);


		}
    }
}
