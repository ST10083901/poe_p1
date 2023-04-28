﻿



using poe_p1;
using System;
using System.Collections.Generic;

namespace RecipeScaler
{


    class Program

    {
        static void Main(string[] args)

        {
            Recipe recipe = new Recipe();
            Steps Steps = new Step();
            Ingredient ingredient = new Ingredient();
           
            while (true)
            {
                Console.WriteLine("Welcome to the Donor Management App!");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Ingredient");
                Console.WriteLine("2. Show Steps");
                Console.WriteLine("3. View Recipe");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int menuChoice = Convert.ToInt32(Console.ReadLine());
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddIngredient();
                        break;
                    case "2":
                        AddStep();
                        break;
                    case "3":
                        PrintRecipe();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            
        




        Console.WriteLine("Enter the number of ingredients:");
                int numIngredients = int.Parse(Console.ReadLine());
                 
                for (int i = 0; i < numIngredients; i++)
                {
                    Console.WriteLine($"Enter ingredient name:");
                    string name = Console.ReadLine();

                    Console.WriteLine($"Enter ingredient  quantity:");
                    double quantity = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Enter ingredient  unit of measurement:");
                    string unit = Console.ReadLine();

                    recipe.AddIngredient(name, quantity, unit);
                }

                Console.WriteLine("Enter the number of steps:");
                int numSteps = int.Parse(Console.ReadLine());

                for (int i = 0; i < numSteps; i++)
                {
                    Console.WriteLine($"Enter step  description:");
                    string description = Console.ReadLine();

                    recipe.AddStep(description);
                }

                recipe.PrintRecipe();

                Console.WriteLine("Enter 'scale 0.5', 'scale 2', 'scale 3', 'reset', or 'clear':");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "scale 0.5":
                        recipe.ScaleRecipe(0.5);
                        recipe.PrintRecipe();
                        break;
                    case "scale 2":
                        recipe.ScaleRecipe(2);
                        recipe.PrintRecipe();
                        break;
                    case "scale 3":
                        recipe.ScaleRecipe(3);
                        recipe.PrintRecipe();
                        break;
                    case "reset":
                        recipe.ResetQuantities();
                        recipe.PrintRecipe();
                        break;
                    case "clear":
                        recipe.




ClearRecipe();
                        break;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }
        }

        private static void PrintRecipe()
        {
            throw new NotImplementedException();
        }

        private static void AddStep()
        {
            throw new NotImplementedException();
        }

        private static void AddIngredient()
        {
            throw new NotImplementedException();
        }
    }
}
