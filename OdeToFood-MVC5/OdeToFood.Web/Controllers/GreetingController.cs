using System.Configuration;
using System.Web.Mvc;
using OdeToFood.Web.Models;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET
        public ActionResult Index()
        {
            var model = new GreetingViewModel();
            model.Message = ConfigurationManager.AppSettings["message"];
            return View(model);
        }
    }
}