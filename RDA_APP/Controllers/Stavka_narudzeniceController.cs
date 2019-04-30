using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RDA_APP.Models;

namespace RDA_APP.Controllers
{
    public class Stavka_narudzeniceController : Controller
    {
        private RDAEntities db = new RDAEntities();

        // GET: Stavka_narudzenice
        public ActionResult Index()
        {
            var stavka_narudzenice = db.Stavka_narudzenice.Include(s => s.Narudzbenica).Include(s => s.Reklama);
            return View(stavka_narudzenice.ToList());
        }

        // GET: Stavka_narudzenice/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stavka_narudzenice stavka_narudzenice = db.Stavka_narudzenice.Find(id);
            if (stavka_narudzenice == null)
            {
                return HttpNotFound();
            }
            return View(stavka_narudzenice);
        }

        // GET: Stavka_narudzenice/Create
        public ActionResult Create()
        {
            ViewBag.Narudzbenica_ID = new SelectList(db.Narudzbenica, "Narudzbenica_ID", "Narudzbenica_ID");
            ViewBag.Reklama_ID = new SelectList(db.Reklama, "Reklama_ID", "Naziv");
            return View();
        }

        // POST: Stavka_narudzenice/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Stavka_narudzenice_ID,Reklama_ID,Narudzbenica_ID,Kolicina")] Stavka_narudzenice stavka_narudzenice)
        {
            if (ModelState.IsValid)
            {
                db.Stavka_narudzenice.Add(stavka_narudzenice);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Narudzbenica_ID = new SelectList(db.Narudzbenica, "Narudzbenica_ID", "Narudzbenica_ID", stavka_narudzenice.Narudzbenica_ID);
            ViewBag.Reklama_ID = new SelectList(db.Reklama, "Reklama_ID", "Naziv", stavka_narudzenice.Reklama_ID);
            return View(stavka_narudzenice);
        }

        // GET: Stavka_narudzenice/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stavka_narudzenice stavka_narudzenice = db.Stavka_narudzenice.Find(id);
            if (stavka_narudzenice == null)
            {
                return HttpNotFound();
            }
            ViewBag.Narudzbenica_ID = new SelectList(db.Narudzbenica, "Narudzbenica_ID", "Narudzbenica_ID", stavka_narudzenice.Narudzbenica_ID);
            ViewBag.Reklama_ID = new SelectList(db.Reklama, "Reklama_ID", "Naziv", stavka_narudzenice.Reklama_ID);
            return View(stavka_narudzenice);
        }

        // POST: Stavka_narudzenice/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Stavka_narudzenice_ID,Reklama_ID,Narudzbenica_ID,Kolicina")] Stavka_narudzenice stavka_narudzenice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stavka_narudzenice).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Narudzbenica_ID = new SelectList(db.Narudzbenica, "Narudzbenica_ID", "Narudzbenica_ID", stavka_narudzenice.Narudzbenica_ID);
            ViewBag.Reklama_ID = new SelectList(db.Reklama, "Reklama_ID", "Naziv", stavka_narudzenice.Reklama_ID);
            return View(stavka_narudzenice);
        }

        // GET: Stavka_narudzenice/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stavka_narudzenice stavka_narudzenice = db.Stavka_narudzenice.Find(id);
            if (stavka_narudzenice == null)
            {
                return HttpNotFound();
            }
            return View(stavka_narudzenice);
        }

        // POST: Stavka_narudzenice/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stavka_narudzenice stavka_narudzenice = db.Stavka_narudzenice.Find(id);
            db.Stavka_narudzenice.Remove(stavka_narudzenice);
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
