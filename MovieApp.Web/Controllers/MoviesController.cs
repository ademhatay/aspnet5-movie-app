using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        // action methods

        public IActionResult Index()
        {
            string filmBasligi = "The Godfather";
            string filmAciklamasi = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.";
            string filmYonetmen = "Francis Ford Coppola";
            string[] oyuncular = { "Marlon Brando", "Al Pacino", "James Caan" };

            var m = new Movie();

            m.Title = filmBasligi;
            m.Description = filmAciklamasi;
            m.Director = filmYonetmen;
            m.Players = oyuncular;

            return View(m);
        }

        // /movies/list
        public IActionResult List()
        {
            return View("Movies");
        }

        // /movies/details
        public IActionResult Details()
        {
            return View();
        }
    }
}
