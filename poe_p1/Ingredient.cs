using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poe_p1
{
    internal class Ingredient

    {
        public Ingredient()
        {

        }

        public Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            Ingredients = new List<Ingredient>();
        }

        public string Name { get; set; }
            public double Quantity { get; set; }
            public string Unit { get; set; }
        public List<Ingredient> Ingredients { get; set; }



        
    }

}
