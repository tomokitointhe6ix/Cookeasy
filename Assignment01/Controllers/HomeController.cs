using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Assignment01.Models;

namespace Assignment01.Controllers
{
    public class HomeController : Controller
    {
        public int PageSize = 1;
        private IRecipeRepository repository;

        public HomeController(IRecipeRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View("Home");
        }

        /*[HttpGet]
        public ViewResult AddRecipe()
        {
            return View(); 
        }

        [HttpPost]
        public ViewResult AddRecipe(Recipe recipe)
        {
            Repository.AddRecipes(recipe);
            return View("AddRecipe");
        }*/

        public ViewResult RecipeList()
        {
            return View(repository.Recipes);
        }

        /*public ViewResult ReviewRecipe()
        {
            return View();
        }*/

        public ViewResult ViewRecipe(int id)
        {
            return View(repository.Recipes
                .Where(p => p.RecipeId == id)
                );
        }
    }
}
