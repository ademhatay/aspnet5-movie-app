using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        // action methods
        // /movies/list
        // /movies/list/1
        public IActionResult List(int? id)
        {
            var movies = MovieRepository.Movies;

            if (id != null)
            {
                movies = movies.Where(i => i.GenreId == id).ToList();
            }

            var model = new MoviesViewModel()
            {
                Movies = movies
            };

            return View("Movies", model);
        }

        // /movies/details/1
        public IActionResult Details(int id)
        {
            return View(MovieRepository.GetById(id));
        }
    }
}
