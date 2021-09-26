using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Mod6
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            List<Recipes> recipes = new List<Recipes>();
            
            do
            {
                Console.Write("Would you like to add a recipe to your cookbook? Y/N: ");
                answer = Console.ReadLine().ToUpper();
                            
                if (answer[0] == 'Y')
                {
                    Recipes recipe = CreateRecipe();
                    recipes.Add(recipe);
                }
            } while (answer[0] != 'N');

            
            Console.WriteLine("--------Your Recipes---------");
            foreach (var r in recipes)
            {
                Console.WriteLine(r.GetName());
                r.GetIngredients();
                Console.WriteLine();
            }
            
        }
        
        static public Recipes CreateRecipe()
        {
            Console.Write("Enter Recipe Name: ");
            string recipename = Console.ReadLine();
            
            List<Ingredients> ingredientsList = new List<Ingredients>();
            string ingredient = "";
            do
            {
                Console.WriteLine("Please input ingredients and their properties(Or NA when done): ");
                Console.Write("Ingredient: ");
                ingredient = Console.ReadLine();

                if (ingredient.ToUpper() != "NA")
                {
                    Console.Write("Quantity: ");
                    double quantity;
                    Double.TryParse(Console.ReadLine(), out quantity);
                  
                    Console.Write("Measurement: ");
                    string measurement = Console.ReadLine();
                  
                    ingredientsList.Add(new Ingredients(ingredient, quantity, measurement));  
                }

                

            } while (ingredient.ToUpper() != "NA");

            Recipes recipe = new Recipes(recipename, ingredientsList);
            return recipe;
        }
    }
}