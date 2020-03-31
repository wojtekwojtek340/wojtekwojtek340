using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string name = "Wojciech Wojtowicz";
            return View("Index", name);
        }

        List<CarViewModel> cars;

        public HomeController()
        {
            cars = new List<CarViewModel>();
            cars.Add(new CarViewModel("Focus", "Ford", 72000, "/focus.png"));
            cars.Add(new CarViewModel("Golf", "Volkswagen", 80000, "/golf.png"));
            cars.Add(new CarViewModel("Civic", "Honda", 10000, "/civic.png"));
            cars.Add(new CarViewModel("Megane", "Renualt", 2000000, "/megane.png"));
        }

        public IActionResult GetListOfModels()
        {
            List<string> models = new List<string>();

            foreach(CarViewModel car in cars)
            {
                models.Add(car.Model);
            }

            return View(models);
        }

        public IActionResult GetCarByModel(string model)
        {
            CarViewModel car = cars.Where(c => c.Model.ToLower() == model.ToLower()).FirstOrDefault();
            return View(car);
        }
        
        [HttpGet]
        public IActionResult ContactForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactForm(ContactFormViewModel formViewModel)
        {
            string fullName = formViewModel.FirstName + " " + formViewModel.LastName;
            ViewBag.UserName = fullName;

            return View("ContactFormGreetings");
        } 

        public IActionResult GetAllCars()
        {
            return View(cars);
        }

        public IActionResult IntrestingLinks()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
