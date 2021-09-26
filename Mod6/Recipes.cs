using System;
using System.Collections.Generic;

namespace Mod6
{
    public class Recipes
    {
        private List<Ingredients> _ingredients;
        private string _recipeName;

        public Recipes(string recipeName, List<Ingredients> ingredientsList)
        {
            _recipeName = recipeName;
            _ingredients = ingredientsList;
        }

        public void SetName(string name)
        {
            name = _recipeName;
        }

        public void SetIngredients(List<Ingredients> ingredientsList)
        {
            _ingredients = ingredientsList;
        }

        public string GetName()
        {
            return _recipeName;
        }

        public void GetIngredients()
        {
            foreach (var i in _ingredients)
            { 
                Console.WriteLine(i.Print());
            }

        }
        
    }
}