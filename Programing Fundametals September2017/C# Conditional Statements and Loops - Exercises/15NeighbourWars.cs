using System;

namespace _15NeighbourWars
{
    public class _15NeighbourWars
    {
        public static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;
            

            int roundCounter = 1;
            //int roundCounterPesho = 0;

            while (true)
            {


                if (roundCounter % 2 == 0)
                {
                    peshoHealth = peshoHealth - goshoDamage;

                    if (peshoHealth <= 0)
                    {

                        
                        Console.WriteLine("Gosho won in {0}th round.", roundCounter);
                        break;
                    }
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHealth);
                    
                    
                   
                }
                else
                {
                    goshoHealth = goshoHealth - peshoDamage;

                    if (goshoHealth <= 0)
                    {

                        Console.WriteLine("Pesho won in {0}th round.", roundCounter);
                        break;
                    }
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHealth);

                }
                if (roundCounter%3==0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }
                roundCounter++;
            }
               

               
            
     
        }
    }
}
