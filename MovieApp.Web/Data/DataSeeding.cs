using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Web.Entity;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Data
{
    public static class DataSeeding
    {
        public static void Seed(IApplicationBuilder app)
        {
            // Seed data here
            var scope = app.ApplicationServices.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<MovieContext>();

            context.Database.Migrate();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Movies.Count() == 0)
                {
                    context.Movies.AddRange(new List<Movie>()
                                              {
                           new Movie()
                           {
                               Title = "Film 1",
                               Description = "Description1",
                               Director = "Director1",
                               ImageUrl = "1.jpg",
                               GenreId = 1
                           },
                           new Movie()
                           {
                               Title = "Movie 2",
                               Description =  "Description2",
                               Director = "Director2",
                               ImageUrl = "3.jpg",
                               GenreId = 3
                           },
                           new Movie()
                           {
                               Title = "Film 3",
                               Description = "Description3",
                               Director = "Director3",
                               ImageUrl = "4.jpg",
                               GenreId = 4
                           },
                        });

                    context.SaveChanges();
                }
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(new List<Genre>()
                          {
                           new Genre()
                           {
                               GenreId = 1,
                               Name = "Action"
                           },
                           new Genre()
                           {
                               GenreId = 2,
                               Name = "Comedy"
                           },
                           new Genre()
                           {
                               GenreId = 3,
                               Name = "Drama"
                           },
                           new Genre()
                           {
                               GenreId = 4,
                               Name = "Horror"
                           },
                        });

                    context.SaveChanges();
                }
            }
        }
    }
}
