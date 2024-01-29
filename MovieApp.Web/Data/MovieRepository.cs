using MovieApp.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Data
{
    public class MovieRepository
    {
        private static readonly List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie() { MovieId = 1, Title = "The Godfather", Description = "Description1", Players = new string[] { "Marlon Brando", "Al Pacino", "James Caan" }, ImageUrl = "Godfather.jpg" },
                new Movie() { MovieId = 2, Title = "The Shawshank Redemption", Description =  "Description2", Players = new string[] { "Tim Robbins", "Morgan Freeman", "Bob Gunton" }, ImageUrl = "The-Shawshank-Redemption.jpg"  },
                new Movie() { MovieId = 3, Title = "The Dark Knight", Description = "Description3", Director = "Christopher Nolan", Players = new string[] { "Christian Bale", "Heath Ledger", "Aaron Eckhart" }, ImageUrl = "The-Dark-Knight.jpg" },
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void Add(Movie movie)
        {
            _movies.Add(movie);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.MovieId == id);
        }
    }
}
