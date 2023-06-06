using poe_p1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_P1
{
    internal class RecipeMenu
    {
        private List<Recipe> recipes;
        internal int CalorieNotification;

        public RecipeMenu()
        {
            recipes = new List<Recipe>();

        }
        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public void DisplayRecipeMenu()
        {
            List<Recipe> sortedRecipes = recipes.OrderBy(r => r.Name).ToList();
            foreach (Recipe recipe in sortedRecipes)
            {
                Console.WriteLine(recipe.Name);
            }
        }

        public Recipe ChooseRecipe(int index)
        {
            if (index >= 0 && index < recipes.Count)
            {
                return recipes[index];
            }
            return null;
        }
    }
}

