using System.Web.Mvc;
using Bicycle.Data.Services;

namespace Bicycle.Web.Controllers
{
    public class BikeController : Controller
    {
        IBikeData _db;

        public BikeController(IBikeData db)
        {
            _db = _db;
        }
        
        // GET
        public ActionResult Index()
        {
            var model = _db.GetAll();
            return View(model);
        }
    }
}