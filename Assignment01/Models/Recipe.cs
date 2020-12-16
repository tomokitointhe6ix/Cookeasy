using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace Assignment01.Models
{
    public class Recipe
    {
        //private int recipeId;
        private static int recipeIdIncre;

        public int RecipeId { get; set; } = recipeIdIncre;

        public int RecipeIdIncre
        {
            get
            {
                return recipeIdIncre;
            }

            set
            {
                recipeIdIncre = value;
            }
        }

        [Required(ErrorMessage = "Please enter a recipe name")]
        public string RecipeName { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter ingredients")]
        public string Ingredients { get; set; }

        [Required(ErrorMessage = "Please enter a chef name")]
        public string Chef { get; set; }

        [Required(ErrorMessage = "Please enter preparation time")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter mode than 1 minute")]
        public int PreparationTime { get; set; }
    }
}
