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
    public class MantenimientoServicioController : Controller
    {
        private bd_seguidoresEntities db = new bd_seguidoresEntities();

        // GET: MantenimientoServicio
        public ActionResult Index()
        {
            var servicio = db.servicio.Include(s => s.proveedor);
            return View(servicio.ToList());
        }

        // GET: MantenimientoServicio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            servicio servicio = db.servicio.Find(id);
            if (servicio == null)
            {
                return HttpNotFound();
            }
            return View(servicio);
        }

        // GET: MantenimientoServicio/Create
        public ActionResult Create()
        {
            ViewBag.id_proveedor = new SelectList(db.proveedor, "id_proveedor", "nombre_proveedor");
            return View();
        }

        // POST: MantenimientoServicio/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_servicio,nombre_servicio,precio_servicio,id_proveedor")] servicio servicio)
        {
            if (ModelState.IsValid)
            {
                db.servicio.Add(servicio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_proveedor = new SelectList(db.proveedor, "id_proveedor", "nombre_proveedor", servicio.id_proveedor);
            return View(servicio);
        }

        // GET: MantenimientoServicio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            servicio servicio = db.servicio.Find(id);
            if (servicio == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_proveedor = new SelectList(db.proveedor, "id_proveedor", "nombre_proveedor", servicio.id_proveedor);
            return View(servicio);
        }

        // POST: MantenimientoServicio/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_servicio,nombre_servicio,precio_servicio,id_proveedor")] servicio servicio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(servicio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_proveedor = new SelectList(db.proveedor, "id_proveedor", "nombre_proveedor", servicio.id_proveedor);
            return View(servicio);
        }

        // GET: MantenimientoServicio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            servicio servicio = db.servicio.Find(id);
            if (servicio == null)
            {
                return HttpNotFound();
            }
            return View(servicio);
        }

        // POST: MantenimientoServicio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            servicio servicio = db.servicio.Find(id);
            db.servicio.Remove(servicio);
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
