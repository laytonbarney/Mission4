using System;
using Microsoft.EntityFrameworkCore;

namespace MovieCollection.Models
{
    public class MovieInfoContext : DbContext
    {
        public MovieInfoContext (DbContextOptions<MovieInfoContext> options) : base (options)
        {
            //Leave Blank for now
        }

        //This sets the name of the table to Movies
        public DbSet<MovieDB> Movies { get; set; }

        //This is how the database is initaially seeded
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieDB>().HasData(
                new MovieDB
                {
                    MovieId = 1,
                    Category = "Historical Drama",
                    Title = "Schindler's List",
                    Year = 1993,
                    DirectorName = "Steven Spielberg",
                    Rating = "R",
                    Edited = false

                },
                new MovieDB
                {
                    MovieId = 2,
                    Category = "Sci-Fi",
                    Title = "Inception",
                    Year = 2010,
                    DirectorName = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false
                },
                new MovieDB
                {
                    MovieId = 3,
                    Category = "Drama/Fantasy",
                    Title = "It's a Wonderful Life",
                    Year = 1946,
                    DirectorName = "Frank Capra",
                    Rating = "PG",
                    Edited = false
                }
                );
        }
    }
}
