using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        // action methods

        public IActionResult Index()
        {
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
