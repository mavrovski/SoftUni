using System;

public class Program
{
 public static void Main()
 {

   string City = Console.ReadLine().ToLower();
   var  Sales  = double.Parse(Console.ReadLine());
   var Commision = -1.00;

   if (City == "sofia")
   {
     if(Sales >= 0 && Sales <= 500) Commision = 0.05;
     else if (Sales > 500 && Sales <= 1000) Commision = 0.07;
     else if (Sales > 1000 && Sales <= 10000) Commision = 0.08;
     else if (Sales > 10000 ) Commision = 0.12;
     Console.WriteLine("{0:f2}",Sales*Commision);
   }
   else if (City == "varna")
   {
     if(Sales >= 0 && Sales <= 500) Commision = 0.045;
     else if (Sales > 500 && Sales <= 1000) Commision = 0.075;
     else if (Sales > 1000 && Sales <= 10000) Commision = 0.10;
     else if (Sales > 10000 ) Commision = 0.13;
     Console.WriteLine("{0:f2}",Sales*Commision);
   }
   else if (City == "plovdiv")
   {
     if(Sales >= 0 && Sales <= 500) Commision = 0.055;
     else if (Sales > 500 && Sales <= 1000) Commision = 0.08;
     else if (Sales > 1000 && Sales <= 10000) Commision = 0.12;
     else if (Sales > 10000 ) Commision = 0.145;
     Console.WriteLine("{0:f2}",Sales*Commision);
   }


   if (Commision < 0 )Console.WriteLine("error");


 }
}
