using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TurniptheBeetMKE.Models;

namespace TurniptheBeetMKE.Controllers
{
    public class MarketViewModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MarketViewModels
        public ActionResult Index()
        {
            return View(db.MarketViewModels.ToList());
        }

        // GET: MarketViewModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarketViewModel marketViewModel = db.MarketViewModels.Find(id);
            if (marketViewModel == null)
            {
                return HttpNotFound();
            }
            return View(marketViewModel);
        }

        // GET: MarketViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MarketViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,marketname,Schedule,Address,Products,ZipCode")] MarketViewModel marketViewModel)
        {
            if (ModelState.IsValid)
            {
                db.MarketViewModels.Add(marketViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(marketViewModel);
        }

        // GET: MarketViewModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarketViewModel marketViewModel = db.MarketViewModels.Find(id);
            if (marketViewModel == null)
            {
                return HttpNotFound();
            }
            return View(marketViewModel);
        }

        // POST: MarketViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,marketname,Schedule,Address,Products,ZipCode")] MarketViewModel marketViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(marketViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(marketViewModel);
        }

        // GET: MarketViewModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarketViewModel marketViewModel = db.MarketViewModels.Find(id);
            if (marketViewModel == null)
            {
                return HttpNotFound();
            }
            return View(marketViewModel);
        }

        // POST: MarketViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MarketViewModel marketViewModel = db.MarketViewModels.Find(id);
            db.MarketViewModels.Remove(marketViewModel);
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
