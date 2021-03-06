﻿using System.Web.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class OperacaoController : Controller
    {
        [Authorize]
        public ActionResult EntradaEstoque()
        {
            return View();
        }

        [Authorize]
        public ActionResult SaidaEstoque()
        {
            return View();
        }

        [Authorize]
        public ActionResult PerdaProduto()
        {
            return View();
        }

        [Authorize]
        public ActionResult Inventario()
        {
            return View();
        }
    }
}