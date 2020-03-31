using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WojciechWojtowiczLab7.Services;

namespace WojciechWojtowiczLab7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private PizzaService pizzaService;

        /// <summary>
        /// konstruktor bezparametryczny
        /// </summary>
        public PizzaController()
        {
            pizzaService = new PizzaService();
        }

        /// <summary>
        /// Metoda get pobierajaca wszystkie pizze
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var pizzas = pizzaService.GetHashCode();
            return Ok(pizzas);
        }
    }
}