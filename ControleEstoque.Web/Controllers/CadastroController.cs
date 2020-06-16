using ControleEstoque.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class CadastroController : Controller
    {
        #region GrupoProduto
        //Lista para simular um banco de dados
        private static List<GrupoProdutoModel> _listaGrupoProduto = new List<GrupoProdutoModel>()
        {
            new GrupoProdutoModel() {Id = 1, Nome="Livros",Ativo=true},
            new GrupoProdutoModel() {Id = 2, Nome="Frios",Ativo=false},
            new GrupoProdutoModel() {Id = 3, Nome="café",Ativo=true}
        };

        [Authorize]
        public ActionResult GrupoProduto()
        {
            return View(_listaGrupoProduto);
        }

        [HttpPost]
        [Authorize]
        public ActionResult RecuperarGrupoProduto(int id)
        {
            return Json(_listaGrupoProduto.Find(x => x.Id == id));
        }

        [HttpPost]
        [Authorize]
        public ActionResult ExcluirGrupoProduto(int id)
        {
            var ret = false;
            var grupoproduto = _listaGrupoProduto.Find(x => x.Id == id);
            
            if(grupoproduto != null)
            {
                _listaGrupoProduto.Remove(grupoproduto);
                ret = true;
            }

            return Json(ret);
        }

        [HttpPost]
        [Authorize]
        public ActionResult SalvarGrupoProduto(GrupoProdutoModel model)
        {
            var grupoproduto = _listaGrupoProduto.Find(x => x.Id == model.Id);

            if(grupoproduto == null)
            {
                grupoproduto = model;
                grupoproduto.Id = _listaGrupoProduto.Max(x => x.Id) + 1;
                _listaGrupoProduto.Add(grupoproduto);
            }
            else
            {
                grupoproduto.Nome = model.Nome;
                grupoproduto.Ativo = model.Ativo;
            }

            return Json(grupoproduto);
        }

        #endregion

        [Authorize]
        public ActionResult MarcaProduto()
        {
            return View();
        }

        [Authorize]
        public ActionResult LocalProduto()
        {
            return View();
        }

        [Authorize]
        public ActionResult UnidadeMedida()
        {
            return View();
        }

        [Authorize]
        public ActionResult Produto()
        {
            return View();
        }

        [Authorize]
        public ActionResult Pais()
        {
            return View();
        }
        public ActionResult Estado()
        {
            return View();
        }

        [Authorize]
        public ActionResult Cidade()
        {
            return View();
        }

        [Authorize]
        public ActionResult Fornecedor()
        {
            return View();
        }

        [Authorize]
        public ActionResult PerfilUsuario()
        {
            return View();
        }

        [Authorize]
        public ActionResult Usuario()
        {
            return View();
        }
    }
}