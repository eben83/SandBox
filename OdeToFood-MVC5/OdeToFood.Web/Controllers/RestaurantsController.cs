using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}