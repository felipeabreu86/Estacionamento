using System.Web.Mvc;

namespace Site.Controllers
{
    public class SobreController : Controller
    {
        public ActionResult Index()
        {
            return View("Sobre");
        }
    }
}