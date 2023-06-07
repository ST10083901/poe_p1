using poe_p1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace poe_p1
{
    internal class Recipe


    {
        public string Name { get; }
        public List<Ingredient> Ingredients { get; private set; }
        public List<Step> Steps { get; private set; }

        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
            Steps = new List<Step>();

        }





        public void AddStep(Step step)
        {
            Steps.Add(step);
        }

        public void Scale(double factor)
        {
            foreach (Ingredient ingredient in Ingredients)
            {
                ingredient.ScaleQuantity(factor);
            }
        }
        public void ResetQuantities2()
        {
            foreach (Ingredient ingredient in Ingredients)
            {
                ingredient.ResetQuantity();
            }
        }

        public void DisplayRecipe()
        {
            Console.WriteLine($"Recipe: {Name}");
            Console.WriteLine("Ingredients:");

            foreach (Ingredient ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Name} - {ingredient.Quantity} {ingredient.Unit}");
            }

            Console.WriteLine("Steps:");

            foreach (Step step in Steps)
            {
                Console.WriteLine(step.Description);
            }

            int totalCalories = Ingredients.Sum(i => i.Calories);

            Console.WriteLine($"Total Calories: {totalCalories}");

            if (totalCalories > 300)
            {
                Console.WriteLine("Warning: This recipe exceeds 300 calories.");
            }
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
                Console.WriteLine($". {Steps[i].Description}");
            }
        }


        public void ClearRecipe()
        {
            Ingredient.Clear();
            Steps.Clear();
        }

        internal void DisplayRecipeMenu()
        {
            throw new NotImplementedException();
        }

        internal void AddIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        internal void ResetQuantities()
        {
            throw new NotImplementedException();
        }
    }
}

     /*    public void AddIngredient(string name, double quantity, string unit, int calories, string foodGroup)
        {
            Ingredient.Add(new Ingredient { Name = name, Quantity = quantity, Unit = unit, Calories = calories, FoodGroup = foodGroup });
        }

        internal void AddIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        internal void AddStep(Step step)
        {
            throw new NotImplementedException();
        }

        internal void DisplayRecipeMenu()
        {
            throw new NotImplementedException();
        }
    }
}*/
