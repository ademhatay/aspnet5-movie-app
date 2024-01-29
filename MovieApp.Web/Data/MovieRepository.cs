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
                new Movie() {
                    MovieId = 1,
                    Title = "The Godfather",
                    Description = "Description1",
                    Director = "Director1",
                    Players = new string[] { "Marlon Brando", "Al Pacino", "James Caan" },
                    ImageUrl = "Godfather.jpg",
                    GenreId = 1
                },
                new Movie() {
                    MovieId = 2,
                    Title = "The Shawshank Redemption",
                    Description =  "Description2",
                    Director = "Director2",
                    Players = new string[] { "Tim Robbins", "Morgan Freeman", "Bob Gunton" },
                    ImageUrl = "The-Shawshank-Redemption.jpg",
                    GenreId = 3
                },
                new Movie() {
                    MovieId = 3,
                    Title = "The Dark Knight",
                    Description = "Description3",
                    Director = "Christopher Nolan",
                    Players = new string[] { "Christian Bale", "Heath Ledger", "Aaron Eckhart" },
                    ImageUrl = "The-Dark-Knight.jpg",
                    GenreId = 4
                },
                new Movie() {
                    MovieId = 4,
                    Title = "Movie 4",
                    Description = "Description4",
                    Director = "Director4",
                    Players = new string[] { "Player 1", "Player 2", "Player 3" },
                    ImageUrl = "Godfather.jpg",
                    GenreId = 3
                },
                new Movie() {
                    MovieId = 5,
                    Title = "Movie 5",
                    Description = "Description5",
                    Director = "Director5",
                    Players = new string[] { "Player 1", "Player 2", "Player 3" },
                    ImageUrl = "The-Shawshank-Redemption.jpg",
                    GenreId = 4
                },
                new Movie() {
                    MovieId = 6,
                    Title = "Movie 6",
                    Description = "Description6",
                    Director = "Director6",
                    Players = new string[] { "Player 1", "Player 2", "Player 3" },
                    ImageUrl = "The-Dark-Knight.jpg",
                    GenreId = 1
                },
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
