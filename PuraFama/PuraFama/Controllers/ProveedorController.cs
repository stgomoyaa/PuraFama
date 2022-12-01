using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PuraFama.Models;

namespace PuraFama.Controllers
{
    public class ProveedorController : Controller
    {
        // GET: Proveedor
        bd_seguidoresEntities entidad = new bd_seguidoresEntities();
        public ActionResult Index()
        {
            var listaProveedores = entidad.proveedor;
            return View(listaProveedores.ToList());
        }

        public ActionResult ListaMaestraProveedor()
        {
            var listaProveedores = entidad.proveedor;
            return View(listaProveedores.ToList());
        }

        public ActionResult Servicio(int proveedor)
        {
            var modelo = from p in entidad.servicio where p.proveedor.id_proveedor == proveedor select p;
            return View(modelo.ToList());
        }
    }
}