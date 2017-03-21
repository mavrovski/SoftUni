using System;

public class Program
{
	public static void Main()
	{
		double meterValueInput = double.Parse(Console.ReadLine());
		string typeValue = (Console.ReadLine());
		string typeValueOutput = (Console.ReadLine());
		double converterSwtch = 0;
		double coveterResult = 0;

		switch(typeValue)
		{

		case "m":
			 converterSwtch = meterValueInput;
				break;

		case "mm":
			 converterSwtch = meterValueInput/1000;
				break;

		case "cm":
			 converterSwtch = meterValueInput/100;
				break;
		case "mi":
			 converterSwtch = meterValueInput*1000/0.621371192;
				break;
		case "in":
			 converterSwtch = meterValueInput/39.3700787;
				break;
		case "km":
			 converterSwtch = meterValueInput*1000
				 ;
				break;
		case "ft":
			 converterSwtch = meterValueInput/3.2808399;
				break;
		case "yd":
			 converterSwtch = meterValueInput*0.9144;
				break;
		}

		switch(typeValueOutput)
		{
		case "m":
			 coveterResult = converterSwtch*1;
				break;
		case "mm":
			 coveterResult = converterSwtch*1000;
				break;

		case "cm":
			coveterResult = converterSwtch*100;
				break;
		case "mi":
			coveterResult = converterSwtch/1000*0.621371192;
				break;
		case "in":
			coveterResult = converterSwtch*39.3700787;
				break;
		case "km":
			coveterResult = converterSwtch/1000;
				break;
		case "ft":
			coveterResult = converterSwtch*3.2808399;
				break;
		case "yd":
			coveterResult = converterSwtch/0.9144;
				break;
		}





		Console.WriteLine(coveterResult+" "+typeValueOutput);
	}
}
