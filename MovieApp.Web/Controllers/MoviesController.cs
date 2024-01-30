using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie m)
        {
            if (ModelState.IsValid)
            {
                MovieRepository.Add(m);
                return RedirectToAction("List", "Movies");
            }

            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View(MovieRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Movie m)
        {

            if (ModelState.IsValid)
            {
                MovieRepository.Edit(m);
                // /movies/details/1
                return RedirectToAction("Details", "Movies", new { id = m.MovieId });
            }

            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View(m);
            
        }

        [HttpPost]
        public IActionResult Delete(int MovieId)
        {
            MovieRepository.Delete(MovieId);
            return RedirectToAction("List", "Movies");
        }
    }
}
