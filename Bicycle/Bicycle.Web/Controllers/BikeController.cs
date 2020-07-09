using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Bicycle.Data.Models;
using Bicycle.Data.Services;

namespace Bicycle.Web.Controllers
{
    public class BikeController : Controller
    {
        private readonly IBikeData _db;

        public BikeController(IBikeData db)
        {
            _db = db;
        }

        // GET
        public ActionResult Index()
        {
            //find out how to group- so the grouping can be done per ComponentType
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
        public ActionResult Create(Components components)
        {
            if (ModelState.IsValid)
            {
                _db.Add(components);
                return RedirectToAction("Index");
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Components components)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Details", new {id = components.Id});
            }

            return View(components);
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