using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


// This project was created by Bogdan Nedelea & Stefan Dimitriu
namespace ExamProject.Controllers
{
    public class HomeController : Controller
    {
        private MovieDBContext db = new MovieDBContext();

        public ActionResult Index(string searchedMovie)
        {
            var movies = from m in db.Movies
                         select m;

            if (!String.IsNullOrEmpty(searchedMovie))
            {
                movies = movies.Where(s => s.Title.Contains(searchedMovie));
            }
            return View(movies);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}