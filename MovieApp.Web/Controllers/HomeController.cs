using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string filmBasligi = "The Godfather";
            string filmAciklamasi = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.";
            string filmYonetmen = "Francis Ford Coppola";
            string[] oyuncular = { "Marlon Brando", "Al Pacino", "James Caan" };
            string image = "godfather.jpg";

            var m = new Movie();

            m.Title = filmBasligi;
            m.Description = filmAciklamasi;
            m.Director = filmYonetmen;
            m.Players = oyuncular;
            m.ImageUrl = image;

            return View(m);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
