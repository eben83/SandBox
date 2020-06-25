using System.Web.Mvc;
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

        public ActionResult Create()
        {
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