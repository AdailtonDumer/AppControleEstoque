using System.Web.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sobre()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}