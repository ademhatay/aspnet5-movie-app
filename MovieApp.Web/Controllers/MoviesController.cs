using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        // action methods

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
