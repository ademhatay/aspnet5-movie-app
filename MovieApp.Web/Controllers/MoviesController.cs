using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        // action methods

        public IActionResult Index()
        {
            string movieTitle = "The Godfather";
            string movieDescription = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.";
            string movieDirector = "Francis Ford Coppola";
            string[] actors = { "Marlon Brando", "Al Pacino", "James Caan" };

            ViewBag.MovieTitle = movieTitle;
            ViewBag.MovieDescription = movieDescription;
            ViewBag.MovieDirector = movieDirector;
            ViewBag.Actors = actors;
            return View();
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
