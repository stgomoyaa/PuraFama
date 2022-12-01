using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PuraFama.Models;

namespace PuraFama.Controllers
{
    public class MantenimientoDisenadorController : Controller
    {
        private bd_seguidoresEntities db = new bd_seguidoresEntities();

        // GET: MantenimientoDisenador
        public ActionResult Index()
        {
            return View(db.disenador.ToList());
        }

        // GET: MantenimientoDisenador/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            disenador disenador = db.disenador.Find(id);
            if (disenador == null)
            {
                return HttpNotFound();
            }
            return View(disenador);
        }

        // GET: MantenimientoDisenador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MantenimientoDisenador/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "rut_disenador,nombre_disenador,sueldo_disenador")] disenador disenador)
        {
            if (ModelState.IsValid)
            {
                db.disenador.Add(disenador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(disenador);
        }

        // GET: MantenimientoDisenador/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            disenador disenador = db.disenador.Find(id);
            if (disenador == null)
            {
                return HttpNotFound();
            }
            return View(disenador);
        }

        // POST: MantenimientoDisenador/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "rut_disenador,nombre_disenador,sueldo_disenador")] disenador disenador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(disenador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(disenador);
        }

        // GET: MantenimientoDisenador/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            disenador disenador = db.disenador.Find(id);
            if (disenador == null)
            {
                return HttpNotFound();
            }
            return View(disenador);
        }

        // POST: MantenimientoDisenador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            disenador disenador = db.disenador.Find(id);
            db.disenador.Remove(disenador);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
