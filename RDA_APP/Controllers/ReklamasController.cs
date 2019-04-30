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
    public class ReklamasController : Controller
    {
        private RDAEntities db = new RDAEntities();

        // GET: Reklamas
        public ActionResult Index()
        {
            var reklama = db.Reklama.Include(r => r.Agencija).Include(r => r.Cenovnik).Include(r => r.Odbor).Include(r => r.Privredna_grana).Include(r => r.Tip_reklame);
            return View(reklama.ToList());
        }

        // GET: Reklamas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reklama reklama = db.Reklama.Find(id);
            if (reklama == null)
            {
                return HttpNotFound();
            }
            return View(reklama);
        }

        // GET: Reklamas/Create
        public ActionResult Create()
        {
            ViewBag.Agencija_ID = new SelectList(db.Agencija, "Agencija_ID", "Naziv");
            ViewBag.Cenovnik_ID = new SelectList(db.Cenovnik, "Cenovnik_ID", "Cenovnik_ID");
            ViewBag.Odbor_ID = new SelectList(db.Odbor, "Odbor_ID", "Naziv");
            ViewBag.Priv_grana_ID = new SelectList(db.Privredna_grana, "Priv_grana_ID", "Naziv");
            ViewBag.Tip_reklame_ID = new SelectList(db.Tip_reklame, "Tip_reklame_ID", "Naziv");
            return View();
        }

        // POST: Reklamas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Reklama_ID,Odbor_ID,Tip_reklame_ID,Priv_grana_ID,Agencija_ID,Cenovnik_ID,Naziv,Sifra,Duzina_trajanja")] Reklama reklama)
        {
            if (ModelState.IsValid)
            {
                db.Reklama.Add(reklama);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Agencija_ID = new SelectList(db.Agencija, "Agencija_ID", "Naziv", reklama.Agencija_ID);
            ViewBag.Cenovnik_ID = new SelectList(db.Cenovnik, "Cenovnik_ID", "Cenovnik_ID", reklama.Cenovnik_ID);
            ViewBag.Odbor_ID = new SelectList(db.Odbor, "Odbor_ID", "Naziv", reklama.Odbor_ID);
            ViewBag.Priv_grana_ID = new SelectList(db.Privredna_grana, "Priv_grana_ID", "Naziv", reklama.Priv_grana_ID);
            ViewBag.Tip_reklame_ID = new SelectList(db.Tip_reklame, "Tip_reklame_ID", "Naziv", reklama.Tip_reklame_ID);
            return View(reklama);
        }

        // GET: Reklamas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reklama reklama = db.Reklama.Find(id);
            if (reklama == null)
            {
                return HttpNotFound();
            }
            ViewBag.Agencija_ID = new SelectList(db.Agencija, "Agencija_ID", "Naziv", reklama.Agencija_ID);
            ViewBag.Cenovnik_ID = new SelectList(db.Cenovnik, "Cenovnik_ID", "Cenovnik_ID", reklama.Cenovnik_ID);
            ViewBag.Odbor_ID = new SelectList(db.Odbor, "Odbor_ID", "Naziv", reklama.Odbor_ID);
            ViewBag.Priv_grana_ID = new SelectList(db.Privredna_grana, "Priv_grana_ID", "Naziv", reklama.Priv_grana_ID);
            ViewBag.Tip_reklame_ID = new SelectList(db.Tip_reklame, "Tip_reklame_ID", "Naziv", reklama.Tip_reklame_ID);
            return View(reklama);
        }

        // POST: Reklamas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Reklama_ID,Odbor_ID,Tip_reklame_ID,Priv_grana_ID,Agencija_ID,Cenovnik_ID,Naziv,Sifra,Duzina_trajanja")] Reklama reklama)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reklama).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Agencija_ID = new SelectList(db.Agencija, "Agencija_ID", "Naziv", reklama.Agencija_ID);
            ViewBag.Cenovnik_ID = new SelectList(db.Cenovnik, "Cenovnik_ID", "Cenovnik_ID", reklama.Cenovnik_ID);
            ViewBag.Odbor_ID = new SelectList(db.Odbor, "Odbor_ID", "Naziv", reklama.Odbor_ID);
            ViewBag.Priv_grana_ID = new SelectList(db.Privredna_grana, "Priv_grana_ID", "Naziv", reklama.Priv_grana_ID);
            ViewBag.Tip_reklame_ID = new SelectList(db.Tip_reklame, "Tip_reklame_ID", "Naziv", reklama.Tip_reklame_ID);
            return View(reklama);
        }

        // GET: Reklamas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reklama reklama = db.Reklama.Find(id);
            if (reklama == null)
            {
                return HttpNotFound();
            }
            return View(reklama);
        }

        // POST: Reklamas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reklama reklama = db.Reklama.Find(id);
            db.Reklama.Remove(reklama);
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
