using MovieApp.Web.Entity;
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
                    Title = "Film 1",
                    Description = "Description1",
                    Director = "Director1",
                    ImageUrl = "1.jpg",
                    GenreId = 1
                },
                new Movie() {
                    MovieId = 2,
                    Title = "Movie 2",
                    Description =  "Description2",
                    Director = "Director2",
                    ImageUrl = "3.jpg",
                    GenreId = 3
                },
                new Movie() {
                    MovieId = 3,
                    Title = "Film 3",
                    Description = "Description3",
                    Director = "Director3",
                    ImageUrl = "4.jpg",
                    GenreId = 4
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
            movie.MovieId = _movies.Count() + 1;
            _movies.Add(movie);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.MovieId == id);
        }

        public static void Edit(Movie m)
        {
            // BAD CODE
            foreach (var movie in _movies)
            {
                if (movie.MovieId == m.MovieId)
                {
                    movie.Title = m.Title;
                    movie.Description = m.Description;
                    movie.Director = m.Director;
                    movie.ImageUrl = m.ImageUrl;
                    movie.GenreId = m.GenreId;
                    break;
                }
            }
        }

        public static void Delete(int MovieId)
        {
            var movie = GetById(MovieId);
            if (movie != null)
            {
                _movies.Remove(movie);
            }
        }
    }
}
