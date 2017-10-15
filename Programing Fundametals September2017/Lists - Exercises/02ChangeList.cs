using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string[] comand = Console.ReadLine().Split(' ').ToArray();
            while (true)
            {
                if (comand[0] == "Delete")
                {
                    listOfIntegers.RemoveAll(x => x == int.Parse(comand[1]));
                }
                else if (comand[0] == "Insert")
                {
                    listOfIntegers.Insert(int.Parse(comand[2]),int.Parse(comand[1]));
                }
                if (comand[0] == "Even")
                {
                    for (int i = 0; i < listOfIntegers.Count; i++)
                    {
                        if (listOfIntegers[i] % 2 == 0)
                        {
                            Console.Write("{0} ", listOfIntegers[i]);
                          
                        }
                    }
                    return;
                }
                if (comand[0] == "Odd")
                {
                    for (int i = 0; i < listOfIntegers.Count; i++)
                    {
                        if (listOfIntegers[i] % 2 == 1)
                        {
                            Console.Write("{0} ", listOfIntegers[i]);

                        }
                    }
                    return;
                    
                }
                comand = Console.ReadLine().Split(' ').ToArray();

            }
        }
    }
}
