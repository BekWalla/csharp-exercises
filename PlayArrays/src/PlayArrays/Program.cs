using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayArrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] l = { 1, 1, 2, 3, 5, 8 };
            foreach(int i in l)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
