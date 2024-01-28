using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Home Page";
        }

        public string About()
        {
            return "About Page";
        }
    }
}
