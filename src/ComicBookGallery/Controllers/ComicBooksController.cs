using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;   

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing Spiderman";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor's Octopus' life and his one, last, great act of revenge! Even if Spider-man survives...will Peter Parker?";
            ViewBag.Artists = new string[]
            {
                "script: dan slott",
                "pencils: humberto ramos",
                "inks: victor olazaba",
                "colors: edgar delgado",
                "letters: chris eliopoulos"
            };

            return View();

        }
    }
}