using MorsodItalia.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MorsodItalia.web.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            var categoriasBL = new CategoriasBL();
            var listadeCategorias = categoriasBL.ObtenerCategorias();

            return View(listadeCategorias);
        }
    }
}