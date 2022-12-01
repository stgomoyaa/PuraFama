using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PuraFama.Models;

namespace PuraFama.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private bd_seguidoresEntities bd = new bd_seguidoresEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Validar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Validar(int rut, string pass)
        {
            login us = bd.login.FirstOrDefault(d => d.rut_administrador == rut & d.pass == pass);

            if (us != null)
            {
                return RedirectToAction("Index", "MantenimientoAdministrador");
            }
            else
            {
                return RedirectToAction("NoHallado", "Login");
            }
        }

        public ActionResult NoHallado()
        {
            ViewBag.Error = "No se encontró usuario";
            return View();
        }
    }
}