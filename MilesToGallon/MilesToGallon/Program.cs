using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double Miles;
            double Gallons;
            double milesPerGallon;

            Console.WriteLine("How many miles have you traveled?");
            string Mil = Console.ReadLine();
            Miles = double.Parse(Mil);
            Console.WriteLine("How many gallons of gas have you used?");
            string Gal = Console.ReadLine();
            Gallons = double.Parse(Gal);
            milesPerGallon = Miles / Gallons;
            Console.WriteLine(milesPerGallon);
            Console.ReadLine();
        }
    }
}
