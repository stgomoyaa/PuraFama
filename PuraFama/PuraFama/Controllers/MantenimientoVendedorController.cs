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
    public class MantenimientoVendedorController : Controller
    {
        private bd_seguidoresEntities db = new bd_seguidoresEntities();

        // GET: MantenimientoVendedor
        public ActionResult Index()
        {
            return View(db.vendedor.ToList());
        }

        // GET: MantenimientoVendedor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vendedor vendedor = db.vendedor.Find(id);
            if (vendedor == null)
            {
                return HttpNotFound();
            }
            return View(vendedor);
        }

        // GET: MantenimientoVendedor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MantenimientoVendedor/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "rut_vendedor,nombre_vendedor,sueldo_vendedor")] vendedor vendedor)
        {
            if (ModelState.IsValid)
            {
                db.vendedor.Add(vendedor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vendedor);
        }

        // GET: MantenimientoVendedor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vendedor vendedor = db.vendedor.Find(id);
            if (vendedor == null)
            {
                return HttpNotFound();
            }
            return View(vendedor);
        }

        // POST: MantenimientoVendedor/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "rut_vendedor,nombre_vendedor,sueldo_vendedor")] vendedor vendedor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vendedor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vendedor);
        }

        // GET: MantenimientoVendedor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vendedor vendedor = db.vendedor.Find(id);
            if (vendedor == null)
            {
                return HttpNotFound();
            }
            return View(vendedor);
        }

        // POST: MantenimientoVendedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vendedor vendedor = db.vendedor.Find(id);
            db.vendedor.Remove(vendedor);
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
