using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WojciechWojtowiczLab6.Models;

namespace WojciechWojtowiczLab6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string name = "Wojciech Wojtowicz";
            return View(name);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
