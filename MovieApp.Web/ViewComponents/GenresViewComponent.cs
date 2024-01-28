using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;
using System.Collections.Generic;

namespace MovieApp.Web.ViewComponents
{
    public class GenresViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var turListesi = new List<Genre>()
            {
                new Genre() { Name = "Crime" },
                new Genre() { Name = "Drama" },
                new Genre() { Name = "Action" },
                new Genre() { Name = "Thriller" }
            };

            return View(turListesi);
        }
    }
}
