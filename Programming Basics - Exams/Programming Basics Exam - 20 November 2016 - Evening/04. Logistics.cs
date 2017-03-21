using System;

public class Program
{
	public static void Main()
	{
		var n = int.Parse(Console.ReadLine());
		var totalLoads = 0.00;
		var loadsWithBus=0.00;
		var loadsWithTruck=0.00;
		var loadsWithTrain=0.00;
		var averageLoadsSum=0.00;
		//var zumbuls	 = int.Parse(Console.ReadLine());

		for(int i=1;i<=n;i++)
		{
		var load = int.Parse(Console.ReadLine());
			totalLoads = totalLoads+load;//totalLoads+=load
			if(load <= 3)
			{
			loadsWithBus=loadsWithBus+load;

			}
			else
			{
				if(load >= 4&&load<=11)
				{
				loadsWithTruck+=load;
				}
				else
				{
				loadsWithTrain+=load;
				}
			}
		}
		averageLoadsSum=(loadsWithBus*200.00+loadsWithTruck*175+loadsWithTrain*120)/totalLoads;

		Console.WriteLine("{0:F2}",averageLoadsSum);
		Console.WriteLine("{0:F2}%",loadsWithBus/totalLoads*100.00);
		Console.WriteLine("{0:F2}%",loadsWithTruck/totalLoads*100.00);
		Console.WriteLine("{0:F2}%",loadsWithTrain/totalLoads*100.00);
	}
}
