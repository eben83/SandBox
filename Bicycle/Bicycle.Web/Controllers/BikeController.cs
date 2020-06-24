using System.Web.Mvc;

namespace Bicycle.Web.Controllers
{
    public class BikeController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}