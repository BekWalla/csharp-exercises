using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListsNStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list1 = new List<string>() { "mark", "geode", "lives", "shot", "smile" };

            foreach (string item in list1)
            {
                if (item.Length == 5)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();
        }
    }
}

