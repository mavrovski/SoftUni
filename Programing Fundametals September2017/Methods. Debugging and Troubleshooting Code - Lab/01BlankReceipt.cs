using System;

namespace _01BlankReceipt
{
    public class _01BlankReceipt
    {
        public static void Main(string[] args)
        {
            PrintReciept();

        }
        static void PrintRecieptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void PrintRecieptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
            Console.WriteLine("------------------------------");
        }
        static void PrintRecieptFotter()
        {
            
            Console.WriteLine("\u00A9 SoftUni");
        }
        static void PrintReciept()
        {
            PrintRecieptHeader();
            PrintRecieptBody();
            PrintRecieptFotter();
        }
    }
}
