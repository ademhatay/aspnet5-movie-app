using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        // action methods

        public string Index()
        {
            return "Film Listesi";
        }

        // /movies/list
        public string List()
        {
            return "Film Listesi";
        }

        // /movies/details
        public string Details()
        {
            return "Film Detayları";
        }
    }
}
