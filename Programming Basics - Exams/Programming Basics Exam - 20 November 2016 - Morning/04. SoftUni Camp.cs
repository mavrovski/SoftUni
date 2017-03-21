using System;

public class Program
{
	public static void Main()
	{
	 var n = int.Parse(Console.ReadLine());
     var Groupe = 0;
     double Car = 0, Bus = 0,snallBus =0,bigBus = 0,train=0;
     var sumGroup=0;
     for (int i=1; i<=n; i++)
     {
      Groupe = int.Parse(Console.ReadLine());
      sumGroup += Groupe;
      if (Groupe<=5)
      {
        Car += Groupe;
      }
      else if (Groupe>5 && Groupe<=12)
      {
        Bus+=Groupe;
      }
      else if (Groupe>12 && Groupe<=25)
      {
        snallBus+=Groupe;
      }
      else if (Groupe>25 && Groupe<=40)
      {
        bigBus+=Groupe;
      }
      else
      {
      train+=Groupe;
      }
     }
     Console.WriteLine("{0:F2}%",(Car/sumGroup)*100);
     Console.WriteLine("{0:F2}%",(Bus/sumGroup)*100);
     Console.WriteLine("{0:F2}%",(snallBus/sumGroup)*100);
     Console.WriteLine("{0:F2}%",(bigBus/sumGroup)*100);
     Console.WriteLine("{0:F2}%",(train/sumGroup)*100);
	}
}
