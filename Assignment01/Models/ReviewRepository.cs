using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Models
{
    public class ReviewRepository
    {
        public static List<Review1> reviews = new List<Review1>();

        public static List<Review1> Reviews => reviews;

        public static void AddReviews(Review1 review)
        {
            reviews.Add(review);
        }
    }
}

