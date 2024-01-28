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
                new Movie() { Title = "The Godfather", Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", Director = "Francis Ford Coppola", Players = new string[] { "Marlon Brando", "Al Pacino", "James Caan" }, ImageUrl = "Godfather.jpg" },
                new Movie() { Title = "The Shawshank Redemption", Description =  "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.", Players = new string[] { "Tim Robbins", "Morgan Freeman", "Bob Gunton" }, ImageUrl = "The-Shawshank-Redemption.jpg"  },
                new Movie() { Title = "The Dark Knight", Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", Director = "Christopher Nolan", Players = new string[] { "Christian Bale", "Heath Ledger", "Aaron Eckhart" }, ImageUrl = "The-Dark-Knight.jpg" },
            };
            return View("Movies", filmListesi);
        }

        // /movies/details
        public IActionResult Details()
        {
            return View();
        }
    }
}
