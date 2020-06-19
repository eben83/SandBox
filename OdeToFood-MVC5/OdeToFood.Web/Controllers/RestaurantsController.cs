using System.Web.Mvc;
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
            throw new System.NotImplementedException();
        }

        public ActionResult Edit(int id)
        {
            throw new System.NotImplementedException();
        }

        public ActionResult Details(int id)
        {
            var model = _db.Get(id);
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}