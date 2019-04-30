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
    public class NarudzbenicasController : Controller
    {
        private RDAEntities db = new RDAEntities();

        // GET: Narudzbenicas
        public ActionResult Index()
        {
            var narudzbenica = db.Narudzbenica.Include(n => n.Kompanija).Include(n => n.Zaposleni);
            return View(narudzbenica.ToList());
        }

        // GET: Narudzbenicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Narudzbenica narudzbenica = db.Narudzbenica.Find(id);
            if (narudzbenica == null)
            {
                return HttpNotFound();
            }
            return View(narudzbenica);
        }

        // GET: Narudzbenicas/Create
        public ActionResult Create()
        {
            ViewBag.Kompanija_ID = new SelectList(db.Kompanija, "Kompanija_ID", "Naziv");
            ViewBag.Zaposleni_ID = new SelectList(db.Zaposleni, "Zaposleni_ID", "Ime");
            return View();
        }

        // POST: Narudzbenicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Narudzbenica_ID,Zaposleni_ID,Kompanija_ID,Broj_narudzbenice,Datum")] Narudzbenica narudzbenica)
        {
            if (ModelState.IsValid)
            {
                db.Narudzbenica.Add(narudzbenica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Kompanija_ID = new SelectList(db.Kompanija, "Kompanija_ID", "Naziv", narudzbenica.Kompanija_ID);
            ViewBag.Zaposleni_ID = new SelectList(db.Zaposleni, "Zaposleni_ID", "Ime", narudzbenica.Zaposleni_ID);
            return View(narudzbenica);
        }

        // GET: Narudzbenicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Narudzbenica narudzbenica = db.Narudzbenica.Find(id);
            if (narudzbenica == null)
            {
                return HttpNotFound();
            }
            ViewBag.Kompanija_ID = new SelectList(db.Kompanija, "Kompanija_ID", "Naziv", narudzbenica.Kompanija_ID);
            ViewBag.Zaposleni_ID = new SelectList(db.Zaposleni, "Zaposleni_ID", "Ime", narudzbenica.Zaposleni_ID);
            return View(narudzbenica);
        }

        // POST: Narudzbenicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Narudzbenica_ID,Zaposleni_ID,Kompanija_ID,Broj_narudzbenice,Datum")] Narudzbenica narudzbenica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(narudzbenica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Kompanija_ID = new SelectList(db.Kompanija, "Kompanija_ID", "Naziv", narudzbenica.Kompanija_ID);
            ViewBag.Zaposleni_ID = new SelectList(db.Zaposleni, "Zaposleni_ID", "Ime", narudzbenica.Zaposleni_ID);
            return View(narudzbenica);
        }

        // GET: Narudzbenicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Narudzbenica narudzbenica = db.Narudzbenica.Find(id);
            if (narudzbenica == null)
            {
                return HttpNotFound();
            }
            return View(narudzbenica);
        }

        // POST: Narudzbenicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Narudzbenica narudzbenica = db.Narudzbenica.Find(id);
            db.Narudzbenica.Remove(narudzbenica);
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
