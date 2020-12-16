﻿// <auto-generated />
using Assignment01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment01.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200811232450_Review")]
    partial class Review
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment01.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Chef")
                        .IsRequired();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Ingredients")
                        .IsRequired();

                    b.Property<int>("PreparationTime");

                    b.Property<int>("RecipeIdIncre");

                    b.Property<string>("RecipeName")
                        .IsRequired();

                    b.HasKey("RecipeId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Assignment01.Models.Review1", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Rate");

                    b.Property<int>("RecipeId");

                    b.Property<int>("RecipeIdIncre");

                    b.Property<string>("ReviewText")
                        .IsRequired();

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
