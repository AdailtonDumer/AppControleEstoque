using System.Web.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Sobre()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}