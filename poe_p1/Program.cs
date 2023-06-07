


using poe_p1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace poe_p1
{
    class Program
    {
        static List<Recipe> recipes = new List<Recipe>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display recipe list");
                Console.WriteLine("3. Display recipe");
                Console.WriteLine("4. Scale recipe");
                Console.WriteLine("5. Reset quantities");
                Console.WriteLine("6. Clear all data");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        EnterRecipeDetails();
                        break;
                    case "2":
                        DisplayRecipeList();
                        break;
                    case "3":
                        DisplayRecipe();
                        break;
                    case "4":
                        ScaleRecipe();
                        break;
                    case "5":
                        ResetQuantities();
                        break;
                    case "6":
                        ClearAllData();
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void EnterRecipeDetails()
        {
            Console.Write("Enter the recipe name: ");
            string name = Console.ReadLine();

            Recipe recipe = new Recipe(name);

            Console.Write("Enter the number of ingredients: ");
            int ingredientCount;
            if (!int.TryParse(Console.ReadLine(), out ingredientCount))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"Ingredient {i + 1}:");
                Console.Write("Name: ");
                string ingredientName = Console.ReadLine();
                Console.Write("Quantity: ");
                double quantity;
                if (!double.TryParse(Console.ReadLine(), out quantity))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
                Console.Write("Unit of measurement: ");
                string unit = Console.ReadLine();
                Console.Write("Calories: ");
                int calories;
                if (!int.TryParse(Console.ReadLine(), out calories))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
                Console.Write("Food group: ");
                string foodGroup = Console.ReadLine();

                recipe.AddIngredient(new Ingredient(ingredientName, quantity, unit, calories, foodGroup));
            }

            Console.Write("Enter the number of steps: ");
            int stepCount;
            if (!int.TryParse(Console.ReadLine(), out stepCount))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"Step {i + 1}:");
                Console.Write("Description: ");
                string description = Console.ReadLine();

                recipe.AddStep(new Step(description));
            }

            recipes.Add(recipe);

            Console.WriteLine("Recipe details entered successfully!");
        }

        static void DisplayRecipeList()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes found.");
                return;
            }

            Console.WriteLine("Recipe List:");
            List<string> recipeNames = recipes.Select(r => r.Name).OrderBy(n => n).ToList();

            for (int i = 0; i < recipeNames.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipeNames[i]}");
            }
        }

        static void DisplayRecipe()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes found.");
                return;
            }

            Console.Write("Enter the recipe number: ");
            int recipeNumber;
            if (!int.TryParse(Console.ReadLine(), out recipeNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            if (recipeNumber >= 1 && recipeNumber <= recipes.Count)
            {
                Recipe recipe = recipes[recipeNumber - 1];
                recipe.DisplayRecipeMenu();
            }
            else
            {
                Console.WriteLine("Invalid recipe number.");
            }
        }

        static void ScaleRecipe()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes found.");
                return;
            }

            Console.Write("Enter the recipe number: ");
            int recipeNumber;
            if (!int.TryParse(Console.ReadLine(), out recipeNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            if (recipeNumber >= 1 && recipeNumber <= recipes.Count)
            {
                Recipe recipe = recipes[recipeNumber - 1];

                Console.Write("Enter the scale factor (0.5, 2, or 3): ");
                double factor;
                if (!double.TryParse(Console.ReadLine(), out factor))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }

                recipe.Scale(factor);
                Console.WriteLine("Recipe scaled successfully!");
            }
            else
            {
                Console.WriteLine("Invalid recipe number.");
            }
        }

        private static void ResetQuantities()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes found.");
                return;
            }

            Console.Write("Enter the recipe number: ");
            int recipeNumber;
            if (!int.TryParse(Console.ReadLine(), out recipeNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            if (recipeNumber >= 1 && recipeNumber <= recipes.Count)
            {
                Recipe recipe = recipes[recipeNumber - 1];
                recipe.ResetQuantities();
                Console.WriteLine("Quantities reset successfully!");
            }
            else
            {
                Console.WriteLine("Invalid recipe number.");
            }
        }

        private static void ClearAllData()
        {
            recipes.Clear();
            Console.WriteLine("All data cleared successfully!");
        }
    }
}
