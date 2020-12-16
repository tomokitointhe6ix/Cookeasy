using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Models
{
    public class Repository 
        //: IRecipeRepository
    {
        public static List<Recipe> recipes = new List<Recipe>();

        //public IQueryable<Recipe> Recipes => new List<Recipe>
        //{
        //    new Recipe {}
        //}.AsQueryable<Recipe>();


        public static List<Recipe> Recipes => recipes;

        public static void AddRecipes(Recipe recipe)
        {
            recipes.Add(recipe);
        }
    }
}
