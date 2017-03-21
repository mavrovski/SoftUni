using System;

public class Program
{
	public static void Main()
	{
		string yearType = Console.ReadLine();


		double feastsNoWeekend = double.Parse(Console.ReadLine());//празници койито не са уикенд
		double weekendsHome = double.Parse(Console.ReadLine());//уикендите в Къщи
		double totalPlays = weekendsHome; //тоталните игри (пмощна променлива) равни на укендите в къщи
		double allWeekends = 48;
		double NormalWeekends = allWeekends - weekendsHome; //сумата на уикендите минус уикендите в къжщи
		switch(yearType)
		{
		case "normal":
		totalPlays = totalPlays + (NormalWeekends * 0.75); //or 3.0/4.0  укендите в къщи+уикендите извън вкъщи по 3/4
        totalPlays = totalPlays + (feastsNoWeekend * 2/3);
		break;
		case "leap":
		totalPlays = totalPlays + (NormalWeekends * 0.75);
        totalPlays = totalPlays + (feastsNoWeekend * 2/3);
		totalPlays = totalPlays + (totalPlays * 0.15);
		break;
		}
		Console.WriteLine(Math.Truncate(totalPlays));
	}
}
