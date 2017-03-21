using System;

public class Program
{
	public static void Main()
	{
  var Days = double.Parse(Console.ReadLine());
  var LeftFood = double.Parse(Console.ReadLine());
  var DogFood = double.Parse(Console.ReadLine());
  var CatFood = double.Parse(Console.ReadLine());
  var TurrtleFood = double.Parse(Console.ReadLine());

  var totalFoodDog = DogFood*Days;
  var totalFoodCat = CatFood*Days;
  var totalFoodTurrtle = (TurrtleFood/1000)*Days;

  var TotalFood=totalFoodDog+totalFoodCat+totalFoodTurrtle;
  var Enought=LeftFood-TotalFood;
  var NotEnought=TotalFood-LeftFood;
  if (TotalFood<=LeftFood )
    {
  Console.WriteLine("{0} kilos of food left.",Math.Floor(Enought));
    }
  else
    {
    Console.WriteLine("{0} more kilos of food are needed.",Math.Ceiling(NotEnought));
    }
	}
}
