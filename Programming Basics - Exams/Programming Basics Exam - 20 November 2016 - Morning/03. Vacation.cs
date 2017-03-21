using System;

public class Program
{
	public static void Main()
	{
    var OldPeople = int.Parse(Console.ReadLine());
    var SchoolPeople = int.Parse(Console.ReadLine());
    var NightsCount = int.Parse(Console.ReadLine());
    var TransportKind = Console.ReadLine().ToLower();
    var Sum =0.00;
    var OldPeoplePrice =0.00;
    var SchoolPeoplePrice =0.00;
    var totalPeople= OldPeople+SchoolPeople;
    var Hotel = NightsCount*82.99;
    switch (TransportKind) {
      case "train":
      OldPeoplePrice=24.99;
      SchoolPeoplePrice=14.99;
      Sum=(OldPeoplePrice*OldPeople+SchoolPeoplePrice*SchoolPeople)*2;
      if (totalPeople>=50)
      {
      Sum*=0.50;
      }
      break;
      case "bus":
      OldPeoplePrice=32.50;
      SchoolPeoplePrice=28.50;
      Sum=(OldPeoplePrice*OldPeople+SchoolPeoplePrice*SchoolPeople)*2;
      break;
      case "boat":
      OldPeoplePrice=42.99;
      SchoolPeoplePrice=39.99;
      Sum=(OldPeoplePrice*OldPeople+SchoolPeoplePrice*SchoolPeople)*2;
      break;
      case "airplane":
      OldPeoplePrice=70.00;
      SchoolPeoplePrice=50.00;
      Sum=(OldPeoplePrice*OldPeople+SchoolPeoplePrice*SchoolPeople)*2;
      break;

    }
	  Sum = (Sum+Hotel)+(Hotel+Sum)*0.10;
      Console.WriteLine("{0:F2}",Sum);
	}
}
