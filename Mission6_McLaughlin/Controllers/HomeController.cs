using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = _movieContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddAMovie(Movie response)
        {
            _movieContext.Movies.Add(response);
            _movieContext.SaveChanges();


            return View("Confirmation", response);
        }

        public IActionResult MovieList()
        {
            var passMovies = _movieContext.Movies.ToList(); // Convert InternalDbSet<Movie> to List<Movie>
            return View(passMovies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var movie = _movieContext.Movies.Find(id);

            ViewBag.Categories = _movieContext.Categories.ToList();
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            _movieContext.Update(movie);
            _movieContext.SaveChanges();
            return RedirectToAction("MovieList");

        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            var movie = _movieContext.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            } 

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _movieContext.Movies.Remove(movie);
            _movieContext.SaveChanges();
            return RedirectToAction(nameof(MovieList));
        }


    }
}
