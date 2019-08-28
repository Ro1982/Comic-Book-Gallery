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
       public string Detail()
        {
            return "Hello from the comic books controller!";
        }
    }
}