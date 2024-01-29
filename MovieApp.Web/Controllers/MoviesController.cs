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
        public IActionResult List(int? id, string q)
        {
            var movies = MovieRepository.Movies;

            if (id != null)
            {
                movies = movies.Where(i => i.GenreId == id).ToList();
            }

            if (!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(i => i.Title.ToLower().Contains(q.ToLower()) || i.Description.ToLower().Contains(q.ToLower())).ToList();
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie m)
        {
            // Model Binding

            //var m = new Movie()
            //{
            //    Title = Title,
            //    Description = Description,
            //    Director = Director,
            //    ImageUrl = ImageUrl,
            //    GenreId = GenreId
            //};

            MovieRepository.Add(m);

            return RedirectToAction("List", "Movies");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(MovieRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            MovieRepository.Edit(m);
            // /movies/details/1
            return RedirectToAction("Details", "Movies", new {id = m.MovieId});
        }
    }
}
