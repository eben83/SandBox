using System.Web.Mvc;
using OdeToFood.Data.Models;
using OdeToFood.Data.Services;

namespace OdeToFood.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IRestaurantData _db;

        public RestaurantsController(IRestaurantData db)
        {
            _db = db;
        }
        // GET
        public ActionResult Index()
        {
            var model = _db.GetAll();
            return View(model);
        }
        
        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _db.Add(restaurant);
                return View();   
            }

            return View();
        }

        public ActionResult Edit(int id)
        {
            throw new System.NotImplementedException();
        }

        public ActionResult Details(int id)
        {
            var model = _db.Get(id);
            if (model == null)

            {
                //if object is null redirect to
                return RedirectToAction("NotFound");
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