using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment01.Models;
using Microsoft.AspNetCore.Authorization;

namespace Assignment01.Controllers
{
    public class ReviewController : Controller
    {
        private IReviewRepository reviewRepository;
        private IRecipeRepository recipeRepository;
       
        public ReviewController(IReviewRepository reviewRepo, IRecipeRepository recipeRepo)
        {
            reviewRepository = reviewRepo;
            recipeRepository = recipeRepo;
        }

        //Display specific review
        public ViewResult ReviewRecipe(int id)
        {
            Review1 newReview = new Review1();
            newReview.RecipeId = id;

            return View(newReview);
        }

        //Save a new review
        [HttpPost]
        public IActionResult ReviewRecipe(Review1 review)
        {
            if (ModelState.IsValid)
            {
                reviewRepository.SaveReview(review);
                TempData["message"] = $"Review has been saved.";
                return RedirectToAction("RecipeList", "Home");
            }
            else
            {
                TempData["message"] = $"Review has not been saved.";
                return View(review);
            }
        }

        public ViewResult ReviewList(int id)
        {
            List<Recipe> getName = new List<Recipe>();
            /*string name;
             string name = getName.Find(x => x.RecipeId == id).RecipeName;
            
            TempData["message"] = name;*/

            return View(reviewRepository.Reviews
                .Where(p => p.RecipeId == id)
                );
        }
    }
}
