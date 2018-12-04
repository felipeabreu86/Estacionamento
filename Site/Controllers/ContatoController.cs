using Site.Models.ViewModels;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class ContatoController : Controller
    {
        public ActionResult Index()
        {
            return View("Contato", new ViewModelContato());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void EnviarFormulario(ViewModelContato contato)
        {
            //tratar formulário
        }
    }
}