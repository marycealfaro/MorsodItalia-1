using MorsodItalia.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MorsodItalia.WebAdmin.Controllers
{
    public class ProductosController : Controller
    {
        ProductosBL _prodctosBL;
        CategoriasBL _categoriasBL;

        public ProductosController()
        {
            _prodctosBL = new ProductosBL();
            _categoriasBL = new CategoriasBL();
        }

        // GET: Productos
        public ActionResult Index()
        {
            var listadeProductos = _prodctosBL.ObtenerProductos();

            return View(listadeProductos);
        }

        public ActionResult Crear()
        {
            var nuevoProducto = new Producto();
            var categorias = _categoriasBL.ObtenerCategorias();

            ViewBag.ListaCategorias = new SelectList(categorias, "Id", "Descripcion");

            return View(nuevoProducto);
        }

        [HttpPost]
        public ActionResult Crear(Producto producto)
        {
            _prodctosBL.GuardarProducto(producto);

            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            var producto = _prodctosBL.ObtenerProducto(id);
            var categorias = _categoriasBL.ObtenerCategorias();

            ViewBag.CategoriaId = new SelectList(categorias, "Id", "Descripcion", producto.CategoriaId);

            return View (producto);
        }

        [HttpPost]
        public ActionResult Editar(Producto producto)
        {
            _prodctosBL.GuardarProducto(producto);

            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int id)
        {
            var producto = _prodctosBL.ObtenerProducto(id);

            return View(producto);
        }

        public ActionResult Eliminar(int id)
        {
            var producto = _prodctosBL.ObtenerProducto(id);

            return View(producto);
        }

        [HttpPost]
        public ActionResult Eliminar(Producto producto)
        {
            _prodctosBL.EliminarProducto(producto.Id);

            return RedirectToAction("Index");
        }
    }
}