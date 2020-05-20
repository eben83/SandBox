using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AnimalFarm.Core.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AnimalFarm.WebClient.Models;

namespace AnimalFarm.WebClient.Controllers
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

       public ActionResult AddAnimal(AddAnimalViewModel animalTypes, string animalName)
       {
           var animalType = animalTypes.SelectedAnimalType;
           var name = animalTypes.AnimalName;
           return View();
       }

       public IActionResult InteractWithOneAnimal()
       {
           return View();
       }

       public IActionResult InteractWithAllAnimals()
       {
           return View();
       }

       public IActionResult Form()
       {
           return View();
       }

       [HttpPost]
       public ActionResult Form(FormViewModel form)
       {
           var firstName = form.FirstName;
           var lastName = form.LastName;
           return View();
       }


       [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}