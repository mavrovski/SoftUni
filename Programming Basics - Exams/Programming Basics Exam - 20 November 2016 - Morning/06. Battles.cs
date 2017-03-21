using System;

public class Program
{
	public static void Main()
	{
		var playerOne  = int.Parse(Console.ReadLine());
	  var playerTwo = int.Parse(Console.ReadLine());
    var FightCount= int.Parse(Console.ReadLine());
    var count = 0;
    for (int i=1; i<=playerOne; i++)
    {
        for (int j=1; j<=playerTwo; j++)
        {
          Console.Write("({0} <-> {1}) ", i, j);
          count++;
          if (count==FightCount)
          {
          break;

          }

        }
      if (count==FightCount)
      {
      	break;

      }

    }

	}
}
