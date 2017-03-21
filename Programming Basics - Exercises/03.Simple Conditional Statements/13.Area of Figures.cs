using System;

public class Program
{
	public static void Main()
	{
		string Figure = Console.ReadLine();
		double Output = 0;

		if(Figure == "square")

		{
		double squareSideO = double.Parse(Console.ReadLine());
			Output = squareSideO*squareSideO;
		}
		else if(Figure == "rectangle")
		{
		double RectangleSideOne = double.Parse(Console.ReadLine());
			double RectangleSideTwo = double.Parse(Console.ReadLine());
			Output = RectangleSideOne*RectangleSideTwo;
		}
		else if(Figure == "circle")
		{
		double circleRadius = double.Parse(Console.ReadLine());
			Output = Math.PI*circleRadius*circleRadius;
		}
		else if(Figure == "triangle")
		{
		double triangleSide = double.Parse(Console.ReadLine());
			double triangleHeight = double.Parse(Console.ReadLine());
			Output = triangleSide * triangleHeight/2;
		}
		Console.WriteLine(Output);
	}
}
