using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieApp.Web.Data;
using MovieApp.Web.Entity;
using MovieApp.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Web.Controllers
{

    public class MoviesController : Controller
    {
        private readonly MovieContext _context;

        public MoviesController(MovieContext context)
        {
            _context = context;
        }

        // action methods
        // /movies/list
        // /movies/list/1
        public IActionResult List(int? id, string q)
        {
            //var movies = MovieRepository.Movies;

            var movies = _context.Movies.AsQueryable();

            if (id != null)
            {
                movies = movies.Where(i => i.GenreId == id);
            }

            if (!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(i => i.Title.ToLower().Contains(q.ToLower()) || i.Description.ToLower().Contains(q.ToLower()));
            }

            var model = new MoviesViewModel()
            {
                Movies = movies.ToList(),
            };

            return View("Movies", model);
        }

        // /movies/details/1
        public IActionResult Details(int id)
        {
            return View(_context.Movies.Find(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie m)
        {
            if (ModelState.IsValid)
            {
                //MovieRepository.Add(m);
                _context.Movies.Add(m);
                _context.SaveChanges(); 
                TempData["Message"] = $"{m.Title} added";
                return RedirectToAction("List", "Movies");
            }

            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
            return View(_context.Movies.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Movie m)
        {

            if (ModelState.IsValid)
            {
                //MovieRepository.Edit(m);
                _context.Movies.Update(m);
                // /movies/details/1
                return RedirectToAction("Details", "Movies", new { id = m.MovieId });
            }

            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
            return View(m);

        }

        [HttpPost]
        public IActionResult Delete(int MovieId, string Title)
        {
            //MovieRepository.Delete(MovieId);
            var entity = _context.Movies.Find(MovieId);
            _context.Movies.Remove(entity);
            _context.SaveChanges();
            TempData["Message"] = $"{Title} deleted";
            return RedirectToAction("List", "Movies");
        }
    }
}
