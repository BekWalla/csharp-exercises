using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Area
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double radius;
            double answer;

            Console.WriteLine("What is the radius of the circle?");
            string areaInput = Console.ReadLine();
            radius = double.Parse(areaInput);
            answer = Math.PI * radius * radius;
            Console.WriteLine("The area of your circle is {0}", answer);
            Console.ReadLine();
        }
    }
}
