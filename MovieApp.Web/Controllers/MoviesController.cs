using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System.Collections.Generic;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        // action methods
        // /movies/list
        public IActionResult List()
        {
            var filmListesi = new List<Movie>()
            {
                new Movie() { Title = "The Godfather", Description = "Description1", Players = new string[] { "Marlon Brando", "Al Pacino", "James Caan" }, ImageUrl = "Godfather.jpg" },
                new Movie() { Title = "The Shawshank Redemption", Description =  "Description2", Players = new string[] { "Tim Robbins", "Morgan Freeman", "Bob Gunton" }, ImageUrl = "The-Shawshank-Redemption.jpg"  },
                new Movie() { Title = "The Dark Knight", Description = "WDescription3", Director = "Christopher Nolan", Players = new string[] { "Christian Bale", "Heath Ledger", "Aaron Eckhart" }, ImageUrl = "The-Dark-Knight.jpg" },
            };

          
            var model = new MovieGenreViewModel()
            {
                Movies = filmListesi,
            };

            return View("Movies", model);
        }

        // /movies/details
        public IActionResult Details()
        {
            return View();
        }
    }
}
