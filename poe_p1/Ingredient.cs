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

        public string Name { get; }
        public double Quantity { get; private set; }
        public string Unit { get; }
        public int Calories { get; }
        public string FoodGroup { get; }

        public Ingredient(string name, double quantity, string unit, int calories, string foodGroup)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            Calories = calories;
            FoodGroup = foodGroup;
        }
        public void AddIngredient(Ingredient ingredient)
        {
            Ingredient.Add(ingredient);
        }


        private static void Add(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void ScaleQuantity(double factor)
        {
            Quantity *= factor;
        }
        public void ResetQuantity()
        {
            Quantity = 0;
        }

        internal static void Clear()
        {
            throw new NotImplementedException();
        }
    }
}

