using System;
using System.Numerics;

namespace _18DifferentIntegersSize
{
    public class _18DifferentIntegersSize
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            

            sbyte @sbyte;
            bool isSbyte = sbyte.TryParse(input,out @sbyte);
            byte @byte;
            bool isbyte = byte.TryParse(input, out @byte);
            short @short;
            bool isShort = short.TryParse(input, out @short);
            ushort @ushort;
            bool isUshort = ushort.TryParse(input, out @ushort);
            int @int;
            bool isInt = int.TryParse(input, out @int);
            uint @uint;
            bool isUint = uint.TryParse(input, out @uint);
            long @long;
            bool isLong = long.TryParse(input, out @long);

            //if (BigInteger.Parse(input)>long.MaxValue)
            //{
            //    Console.WriteLine("{0} can't fit in any type", input);

            //}
            if (isLong != true)
            {
                Console.WriteLine("{0} can't fit in any type", input);

            }
            else
            {


                Console.WriteLine($"{input} can fit in:");
                if (isSbyte)
                {
                    Console.WriteLine("* sbyte");
                }
                if (isbyte)
                {
                    Console.WriteLine("* byte");
                }
                if (isShort)
                {
                    Console.WriteLine("* short");

                }
                if (isUshort)
                {
                    Console.WriteLine("* ushort");
                }
                if (isInt)
                {
                    Console.WriteLine("* int");
                }
                if (isUint)
                {
                    Console.WriteLine("* uint");
                }
                if (isLong)
                {
                    Console.WriteLine("* long");
                }
            }


        }
    }
}
