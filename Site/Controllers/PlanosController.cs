using System.Web.Mvc;

namespace Site.Controllers
{
    public class PlanosController : Controller
    {
        public ActionResult Index()
        {
            return View("Planos");
        }
    }
}