using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment01.Models;
using Microsoft.AspNetCore.Authorization;

namespace Assignment01.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IRecipeRepository repository;

        public AdminController(IRecipeRepository repo)
        {
            repository = repo;
        }

        //public ViewResult Index() => View(repository.Recipes);

        public ViewResult Update(int recipeId) => 
            View(repository.Recipes.FirstOrDefault(p => p.RecipeId == recipeId));

        [HttpPost]
        public IActionResult Update(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                repository.SaveRecipe(recipe);
                TempData["message"] = $"{recipe.RecipeName} has been saved.";
                return RedirectToAction("RecipeList", "Home");
            }
            else
            {
                return View(recipe);
            }
        }

        public ViewResult AddRecipe() => View(new Recipe());

        [HttpPost]
        public IActionResult Delete(int recipeId)
        {
            Recipe deletedRecipe = repository.DeleteRecipe(recipeId);

            if (deletedRecipe != null)
            {
                TempData["message"] = $"{deletedRecipe.RecipeName} is deleted.";
            }

            return RedirectToAction("RecipeList", "Home");
        }
    }
}
