using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Generator;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek!"
            };
           // return View(movie);

            //return Content("Hellow World");
            //return HttpNotFound();

            return RedirectToAction("Index","Home", new {page = 1, sorttBy="name"});

        }

        public ActionResult Edit(int id)
        {
            return Content("id="+id);
        }
        //optional params  ? makes int nullable. string is be default
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        }
    }
}