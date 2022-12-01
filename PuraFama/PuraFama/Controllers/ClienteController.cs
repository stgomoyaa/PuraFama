using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PuraFama.Models;

namespace PuraFama.Controllers
{
    public class ClienteController : Controller
    {
        bd_seguidoresEntities entidad = new bd_seguidoresEntities();
        public ActionResult ListaMaestraCliente()
        {
            var listaClientes = entidad.cliente;
            return View(listaClientes.ToList());
        }

        public ActionResult Venta(int cliente)
        {
            var modelo = from p in entidad.venta where p.cliente.rut_cliente == cliente select p;
            return View(modelo.ToList());
        }
    }
}