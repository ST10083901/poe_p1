using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poe_p1
{
    internal class Recipe
    
        
        {
        public List<Ingredient> Ingredient { get; }
        public List<Steps> Steps { get; set; }

            public Recipe()
            {
            Ingredient = new List<Ingredient>();
            Steps = new List<Steps>();
            }

       

        public void AddStep(string description)
        {
            Steps.Add(new Step { Description = description });
        }
        public void PrintRecipe()
        {
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredient)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i].Description}");
            }
        }


        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredient)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void ResetQuantities()
        {
            foreach (var ingredient in Ingredient)
            {
                ingredient.Quantity /= 2;
            }
        }


        public void ClearRecipe()
        {
            Ingredient.Clear();
            Steps.Clear();
        }

        public void AddIngredient(string name, double quantity, string unit)
        {
            Ingredient.Add(new Ingredient { Name = name, Quantity = quantity, Unit = unit });
        }
    }
}
