using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06.Models
{
    public class MovieApplicationContext : DbContext
    {
        public MovieApplicationContext (DbContextOptions<MovieApplicationContext> options) : base (options)
        {
            //Leave blank for now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
            ) ;

            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    ApplicationId = 1,
                    Title = "The Avengers",
                    CategoryId = 1,
                    Year = 2018,
                    Director = "Joss Whedon",
                    Rating = "PG-13"
                },
                new ApplicationResponse
                {
                    ApplicationId = 2,
                    Title = "Star Wars",
                    CategoryId = 1,
                    Year = 1977,
                    Director = "George Lucas",
                    Rating = "PG"
                },
                new ApplicationResponse
                {
                    ApplicationId = 3,
                    Title = "Braveheart",
                    CategoryId = 1,
                    Year = 1995,
                    Director = "Mel Gibson",
                    Rating = "R"
                }
            );
        }
    }
}
