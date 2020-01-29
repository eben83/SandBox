using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLcoffeeMachine.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BLcoffeeMachine.Controllers
{
    public class GroupController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(Group newGroup)
        {
            return View("Index", newGroup); // this is the group index file form the group folder
                                            // the newGroup will bind the info from text box to the Name (Grpup.cs file)
        }

    }
}
