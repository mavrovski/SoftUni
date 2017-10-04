using System;

namespace _01HelloName_
{
    public class _01HelloName_
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
              HelloMethod(name);
            
        }

        private static void HelloMethod(string name)
        {

             Console.WriteLine("Hello, {0}!",name); 
        }
    }
}
