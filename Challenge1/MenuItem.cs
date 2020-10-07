using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class MenuItem
    {

        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        public MenuItem(int num, string inputname, string desc, string ingr, double inputprice)
        {
            Number = num;
            Name = inputname;
            Description = desc;
            Ingredients = ingr;
            Price = inputprice;
        }


    }
}
