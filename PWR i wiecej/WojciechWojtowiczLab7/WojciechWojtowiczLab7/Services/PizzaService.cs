using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WojciechWojtowiczLab7.Models;

namespace WojciechWojtowiczLab7.Services
{
    public class PizzaService
    {
        private static List<Pizza> pizzas = new List<Pizza>();
        
        public List<Pizza> Get()
        {
            return pizzas;
        }
    }
}
