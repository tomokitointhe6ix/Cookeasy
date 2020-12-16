using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment01.Models;

namespace Assignment01.Models
{
    public class EFReviewRepository : IReviewRepository
    {
        private ApplicationDbContext context;

        public EFReviewRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Review1> Reviews => context.Reviews;

        public void SaveReview(Review1 review)
        {
            if (review.ReviewId == 0)
            {
                context.Reviews.Add(review);
            }
            else
            {
                Review1 reviewEntry = context.Reviews
                    .FirstOrDefault(r => r.ReviewId == review.ReviewId);

                if (reviewEntry != null)
                {
                    reviewEntry.ReviewBody = review.ReviewBody;
                    reviewEntry.Rating = review.Rating;
                    //Add RecipeId
                    reviewEntry.RecipeId = review.RecipeId;
                }
            }
            context.SaveChanges();
        }
    }
}
