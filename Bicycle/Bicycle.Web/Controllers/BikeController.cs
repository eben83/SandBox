﻿using System.Collections.Generic;
using System.Web.Mvc;
using Bicycle.Data.Models;
using Bicycle.Data.Services;

namespace Bicycle.Web.Controllers
{
    public class BikeController : Controller
    {
        private readonly IBikeData _db;

        public BikeController()
        {
            _db = new InMemoryBikeData();
        }

        // GET
        public ActionResult Index()
        {
            var model = _db.GetAll();
            return View(model);
        }
        
        public ActionResult Details(int id)
        {
            var model = _db.Get(id);
            if (model == null)
            {
                return RedirectToAction("NotFound");
            }
            
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Bike bike)
        {
            if (ModelState.IsValid)
            {
                _db.Add(bike);
                return RedirectToAction("Details");
            }

            return View();
        }

        public ActionResult Edit(int id)
        {
            var model = _db.Get(id);
            if (model == null)
            {
                RedirectToAction("NotFound");
            }

            return View(model);
        }

        
        public ActionResult Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public ActionResult NotFound()
        {
            return View();
        }
    }
}