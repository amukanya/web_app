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
       
        // GET:  /<controller>/
        [HttpGet]
        public IActionResult Index(string name = "World")
        {
            //Checking name value and assigning one if not found
            // if (string.IsNullOrEmpty(name))
            // {
            //     name  ="World";
            // }

            string html = "<form method = 'post'>" +
                "<input type = 'text' name = 'name' />" +
                "<input type = 'submit' value = 'Greet me !'/>" +
                "</form>";
            //return Content(html, "text/html");    
            return Redirect("/HelloWorld/Goodbye");
        }

        //Hello
        [Route("/HelloWorld")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(String.Format("<h1>Hello {0}</h1>",name),"text/html");
        }

        // Handle requests to /Hello/Andy(URL segement)
        [Route("/HelloWorld/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(String.Format("<h1>Hello {0}</h1>",name),"text/html");
        }


        // // /Hello/Goodbye
        // //alter the route to thid controller to be : /Hello/Aloha
        // [Route("/Hello/Aloha")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye!");
        }
    }
}