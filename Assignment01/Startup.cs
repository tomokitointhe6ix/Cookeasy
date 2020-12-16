using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Assignment01.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Assignment01
{
    public class Startup
    {
        //Property
        public IConfiguration Configuration { get; }

        //Constructor
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            //Connection to the database
            services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer
            (Configuration["Data:Assignment01:ConnectionStrings"]));
            //Dependency Injection for recipes
            services.AddTransient<IRecipeRepository, EFRecipeRepository>();
            //Dependency Injection for reviews
            services.AddTransient<IReviewRepository, EFReviewRepository>();

            //Connection to the database -> identity
            services.AddDbContext<AppIdentityDbContext>(option => option.UseSqlServer
            (Configuration["Data:Assignment01Identity:ConnectionStrings"]));
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppIdentityDbContext>()
                .AddDefaultTokenProviders();
            
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();
            //app.Session();
            //app.UseMvcWithDefaultRoute();
            app.UseAuthentication();

            app.UseMvc(routes => {

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                //    //routes.MapRoute(
                //    //    name: null,
                //    //    template: "Page{productPage:int}",
                //    //    defaults: new { controller = "Product", action = "List", productPage = 1 }
                //    //);

                routes.MapRoute(
                     name: null,
                     template: "{controller}/{action}/{id?}");
            });

            SeedData.EnsurePopulated(app);
            IdentitySeedData.EnsurePopulated(app);
            //ReviewSeedData.EnsurePopulated(app);

        }
    }
}
