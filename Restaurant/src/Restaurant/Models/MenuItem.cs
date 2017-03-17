using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class MenuItem
    {
        private string name;
        private double price;
        private string description;
        private string category;

        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public MenuItem(string name, double price, string description, string category)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
        }
    }
}
