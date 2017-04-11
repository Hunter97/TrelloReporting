using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TrelloReporting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "In development";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "In development";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public int isSelected( int selection )
        {
            return selection;
        }
    }
}
