using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double len;
            double wid;
            double answer;

            Console.WriteLine("What is the length of the rectangle?");
            string length = Console.ReadLine();
            len = double.Parse(length);
            Console.WriteLine("What is the width of the rectangle?");
            string width = Console.ReadLine();
            wid = double.Parse(width);
            answer = len * wid;
            Console.WriteLine(answer);
            Console.ReadLine();
  
        }
    }
}
