using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Models
{
    public interface IReviewRepository
    {
        IQueryable<Review1> Reviews { get; }

        void SaveReview(Review1 review);
    }
}
