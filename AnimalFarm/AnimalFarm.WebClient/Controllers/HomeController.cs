using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AnimalFarm.Core.Domain;
using AnimalFarm.Core.Infrastructure;
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
            //creates a new instance of the View Model
            var vm = new AnimalFarmViewModel();

            //creates a new instance of the Animal
            var testAnimal = AnimalFactory.CreateAnimal(AnimalTypes.Cat, "John");
            
            //adds the test data to the list
            vm.Animals.Add(testAnimal);

            //this is to pass the View Model around the app, that will keep the state of the list
            TempData["AnimalVm"] = (vm);
            
            //returns the view with the View Model passed in
            return View(vm);
        }

       public ActionResult AddAnimal(AddAnimalViewModel animalTypes, string Name)
       {
           var animalType = animalTypes.SelectedAnimalType;
           var animalName = animalTypes.AnimalName;
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