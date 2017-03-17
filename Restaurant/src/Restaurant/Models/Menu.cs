using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Menu
    {
        private string season;
        public List<MenuItem> menuItems;

        public string Season
        {
            get { return season; }
            private set { season = value; }
        }

        public List<MenuItem> MenuItems
        {
            get { return menuItems; }
            set { menuItems = value; }
        }
    }
}