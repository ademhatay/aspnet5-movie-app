using MovieApp.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Data
{
    public class GenreRepository
    {
        private static readonly List<Genre> _genres = null;

        static GenreRepository()
        {
            _genres = new List<Genre>()
            {
                new Genre() { GenreId = 1, Name = "Comedy" },
                new Genre() { GenreId = 2, Name = "Action" },
                new Genre() { GenreId = 3, Name = "Science Fiction" },
                new Genre() { GenreId = 4, Name = "Drama" },
                new Genre() { GenreId = 5, Name = "Romance" },
                new Genre() { GenreId = 6, Name = "Horror" },
                new Genre() { GenreId = 7, Name = "Adventure" },
                new Genre() { GenreId = 8, Name = "War" },
                new Genre() { GenreId = 9, Name = "Crime" },
                new Genre() { GenreId = 10, Name = "Thriller" },
                new Genre() { GenreId = 11, Name = "Fantasy" },
            };
        }

        public static List<Genre> Genres
        {
            get
            {
                return _genres;
            }
        }

        public static void Add(Genre genre)
        {
            _genres.Add(genre);
        }

        public static Genre GetById(int id)
        {
            return _genres.FirstOrDefault(i => i.GenreId == id);
        }
    }
}
