using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Detail() {
            ViewBag.title = "My first ASP app";
            ViewBag.description = "I'm learning .NET ASP";
            ViewBag.testString = "<p>heheheeee - <strong>test</strong><p>";
            ViewBag.characters = new string[]
            {
                "Mario",
                "Princess Peach",
                "Bowser",
                "Toad",
                "Yoshi"
            };

            return View();
        }
    }
}
