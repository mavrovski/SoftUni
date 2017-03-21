using System;



    public class Program
    {
        public static void Main()
        {
           	double Value = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();
            double toLeva = 0f;
            double result = 0f;

            switch(inputCurrency)
            {
                case "BGN":
                    toLeva = Value;
                    break;
                case "USD":
                    toLeva = Value * 1.79549f;
                    break;
                case "EUR":
                    toLeva = Value * 1.95583f;
                    break;
                case "GBP":
                    toLeva =Value * 2.53405f;
                    break;
            }

            switch (outputCurrency)
            {
                case "BGN":
                    result = toLeva;
                    break;
                case "USD":
                    result = toLeva / 1.79549f;
                    break;
                case "EUR":
                    result = toLeva / 1.95583f;
                    break;
                case "GBP":
                    result = toLeva / 2.53405f;
                    break;
            }

            Console.WriteLine(Math.Round(result, 2)+" "+outputCurrency);
        }
    }
