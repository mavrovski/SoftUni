using System;

public class Program
{
	public static void Main()
	{
		var Begin = int.Parse(Console.ReadLine());
		var End = int.Parse(Console.ReadLine());
		var maxCombNumb = int.Parse(Console.ReadLine());
		var	count=1;
		for(int first=Begin;first<=End;first++)
		{

				for(int second=Begin;second<=End;second++)
				{
					Console.Write("<{0}-{1}>",first,second);
					count++;
					if(count>maxCombNumb)
					{
					break;

					}


				}
		if(count>maxCombNumb)
			{
			break;

			}

		}

	}
}
