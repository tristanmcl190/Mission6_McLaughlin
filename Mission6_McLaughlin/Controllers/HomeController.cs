using Microsoft.AspNetCore.Mvc;
using Mission6_McLaughlin.Models;
using System.Diagnostics;

namespace Mission6_McLaughlin.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _movieContext;

        public HomeController(MovieContext temp) //Constructor
        {
            _movieContext = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddAMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAMovie(Movie response)
        {
            _movieContext.Movie.Add(response);
            _movieContext.SaveChanges();


            return View("Confirmation", response);
        }
    }
}
