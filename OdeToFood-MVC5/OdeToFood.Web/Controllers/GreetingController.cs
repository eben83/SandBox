using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}