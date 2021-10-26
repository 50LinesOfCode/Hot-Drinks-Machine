using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hot_Drinks_Machine.Models;

namespace Hot_Drinks_Machine.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
      
        [Route("/home/hotdrink/{drink}")]
        public IActionResult HotDrink(string drink)
        {
            HotDrink hotDrink;
            switch (drink)
            {
                case "lemontea":
                    hotDrink = new LemonTea();
                    return View(hotDrink);
                case "coffee":
                    hotDrink = new Coffee();
                    return View(hotDrink);
                case "chocolate":
                    hotDrink = new Chocolate();
                    return View(hotDrink);
            }
            return BadRequest();
        }
        public IActionResult Coffee()
        {

            Coffee drink = new Coffee();
            return View(drink);
        }
        public IActionResult Chocolate()
        {

            Chocolate drink = new Chocolate();
            return View(drink);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
