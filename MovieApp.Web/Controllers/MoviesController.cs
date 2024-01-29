using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
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
           
            var model = new MoviesViewModel()
            {
                Movies = MovieRepository.Movies,
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
