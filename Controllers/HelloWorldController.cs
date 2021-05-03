using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_app.Models;
using System.Text.Encodings.Web;

namespace web_app.Controllers
{
    public class HelloWorldController : Controller
    {
       

        public IActionResult Index()
        {
            return Content("<h1>Hello World</h1>","text/html");
        }

        

        public IActionResult Goodbye()
        {
            return Content("Goodbye!");
        }
    }
}