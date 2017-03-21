using System;

public class Program
{
	public static void Main()
	{
		int Hour = int.Parse(Console.ReadLine());
		int Minutes = int.Parse(Console.ReadLine());
		//int Time = 0;




		/*if (Hour > 23)
		{
		Hour = 0;
		}*/


		if(Minutes >= 0 && Minutes <= 44 )
		{

		Minutes = Minutes+15;

		}


		else if(Minutes >= 45 )
		{
		Hour = Hour+1;
		Minutes = (Minutes-60)+15;
		//Time = Minutes+15;
		}
		if (Hour >= 24)
		{
		Hour = 0;
		}
		if(Minutes >= 0 && Minutes<10)
		{
		Minutes = 0 + Minutes;
		Console.WriteLine( Hour+":"+"0"+Minutes );
		}
		else
		Console.WriteLine( Hour+":"+Minutes );
	}
}
