using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;

namespace Assignment01.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                    new Recipe
                    {
                        RecipeName = "Chicken Parmesan",
                        Description = "This version of chicken parmesan is a little different than what they do in the restaurants, with less sauce and a crispier crust.",
                        Ingredients = "4 eaches Chicken, broilers or fryers, breast, meat/ 1 pinch Salt, table/ 2 Egg, whole, raw, fresh 1 cup Panko",
                        Chef = "John",
                        PreparationTime = 25
                    },
                    new Recipe
                    {
                        RecipeName = "Yummy Honey Chicken Kabobs",
                        Description = "Honey chicken kabobs with veggies. You can marinate overnight and make these kabobs for an outdoor barbecue as a tasty alternative to the usual barbecue fare! Fresh mushrooms and cherry tomatoes can also be used. (This can also be done in the broiler.)",
                        Ingredients = "¼ cup Oil, vegetable corn, salad or cooking/ ⅓ cup Honey, strained or extracted/ ⅓ cup Soy sauce made from soy and wheat (shoyu)",
                        Chef = "Tomo",
                        PreparationTime = 15
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
