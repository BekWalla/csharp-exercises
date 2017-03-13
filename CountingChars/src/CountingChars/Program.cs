using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountingChars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string longString = ("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.");
            longString = longString.Replace(" ", String.Empty);
            int num = 1;
            Dictionary<char, int> characters =
                new Dictionary<char, int>() { };

            foreach (char character in longString)
            {
                if (characters.ContainsKey(character) == true) 
                {
                    characters[character] += 1;
                }
                else
                {
                    characters.Add(character, num);
                }
            }
            foreach (KeyValuePair<char, int> character in characters)
            {
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
