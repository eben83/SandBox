using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AnimalFarm.Core.Domain;
using AnimalFarm.Core.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AnimalFarm.WebClient.Models;
using Newtonsoft.Json;

namespace AnimalFarm.WebClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AnimalFarmViewModel _model;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _model = new AnimalFarmViewModel();
        }

        private void GetModelFromTempData ()
        {
            var json = TempData["AnimalVm"];
            
            if (json == null)
            {
                return;
            }

            _model = JsonConvert.DeserializeObject<AnimalFarmViewModel>(json.ToString());
        }

        private void SetTempData()
        {
            TempData["AnimalVm"] = JsonConvert.SerializeObject(_model);
        }

        public IActionResult Index()
        {
            GetModelFromTempData();
            return View(_model);
        }

        public IActionResult AddAnimal()
        {
            GetModelFromTempData();
            var addAnimalView = new AddAnimalViewModel();
            SetTempData();
            return View(addAnimalView);
        }

        [HttpPost]
        public IActionResult AddAnimal(AddAnimalViewModel vm)
        {
            GetModelFromTempData();
            var animal = AnimalFactory.CreateAnimal((AnimalTypes)vm.SelectedAnimalType, vm.AnimalName);
            _model.Animals.Add(animal);
            SetTempData();
            return RedirectToAction("Index");
        }

        public IActionResult InteractWithOneAnimal()
        {
            GetModelFromTempData();
            return View();
        }

        public IActionResult InteractWithAllAnimals()
        { 
            GetModelFromTempData();
            return View();
        }

        public IActionResult Form()
        {
           return View();
        }

        [HttpPost]
        public IActionResult Form(FormViewModel form)
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