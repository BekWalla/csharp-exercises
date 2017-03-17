﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        private string name;

    
        public string Name
        {
            get { return name; }
            set { name = value.ToUpper(); }
        }
        public string Description { get; set; }

        public Cheese(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
