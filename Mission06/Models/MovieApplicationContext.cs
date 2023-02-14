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

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    ApplicationId = 1,
                    Title = "The Avengers",
                    Category = "Action",
                    Year = 2018,
                    Director = "Joss Whedon",
                    Rating = "PG-13"
                },
                new ApplicationResponse
                {
                    ApplicationId = 2,
                    Title = "Star Wars",
                    Category = "Action",
                    Year = 1977,
                    Director = "George Lucas",
                    Rating = "PG"
                },
                new ApplicationResponse
                {
                    ApplicationId = 3,
                    Title = "Braveheart",
                    Category = "Action",
                    Year = 1995,
                    Director = "Mel Gibson",
                    Rating = "R"
                }
            );
        }
    }
}
