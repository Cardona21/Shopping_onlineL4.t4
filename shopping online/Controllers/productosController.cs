
using Shopping_Online.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shopping_online.Controllers
{
    public class productosController : Controller
    {
        // GET: productos
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listadeproductos = productosBL.ObtenerProductos();

            return View(listadeproductos);
        }
    }
}