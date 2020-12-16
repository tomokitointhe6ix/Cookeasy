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
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Assignment01.Models
{
    public class Review1
    {

        //[BindNever]
        [Key]
        public int ReviewId { get; set; } 

        [Required(ErrorMessage = "Please enter a review")]
        public string ReviewBody { get; set; }

        //[Required(ErrorMessage = "Please select the number")]
        public int Rating { get; set; }

        public int RecipeId { get; set; }
    }
}
