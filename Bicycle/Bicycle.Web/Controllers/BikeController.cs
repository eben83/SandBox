using System.Web.Mvc;
using Bicycle.Data.Services;

namespace Bicycle.Web.Controllers
{
    public class BikeController : Controller
    {
        IBikeData _db;

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
    }
}