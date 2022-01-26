using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieCollection.Models;

namespace MovieCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //This is added so we can add stuff to the database from our websites
        private MovieInfoContext _blahContext { get; set; }

        //Same as above
        public HomeController(ILogger<HomeController> logger, MovieInfoContext someName)
        {
            _logger = logger;
            _blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MyMovies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MyMovies(MovieDB stuff)
        {
            //These two lines allow us to add stuff to the database
            _blahContext.Add(stuff);
            _blahContext.SaveChanges();

            return View("Confirmation", stuff);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
