using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Lyman.Models;
using SQLitePCL;

namespace Mission06_Lyman.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;
        public HomeController(MovieContext temp)
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult JoelPage()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EnterMovie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EnterMovie(Movie response)
        {
            _context.Movies.Add(response); // Add record to the database
            _context.SaveChanges();

            return View("Confirmation");
        }
    }
}
