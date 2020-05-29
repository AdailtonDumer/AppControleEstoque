using System.Web.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class GraficoController : Controller
    {
        [Authorize]
        public ActionResult PerdaMes()
        {
            return View();
        }

        [Authorize]
        public ActionResult EntradaSaidaMes()
        {
            return View();
        }
    }
}