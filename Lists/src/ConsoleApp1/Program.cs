using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 8, 9, 1, 10, 12, 55, 89, 1, 2};
            int answer = numbers.Sum();
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
