using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TurnipTheBeetMKE.Models;

namespace TurnipTheBeetMKE.Controllers
{
    public class FarmersMarketsController : ApplicationBaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FarmersMarkets
        public ActionResult Index()
        {
            var farmersMarkets = db.FarmersMarkets.Include(f => f.GoogleMap).Select(f => new FarmersMarketViewModel()
            {
                marketname = f.marketname,
                Schedule = f.Schedule,
                Address = f.Address,
                Products = f.Products
            });
            return View(farmersMarkets.ToList());
        }

        // GET: FarmersMarkets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FarmersMarket farmersMarket = db.FarmersMarkets.Find(id);
            if (farmersMarket == null)
            {
                return HttpNotFound();
            }
            return View(farmersMarket);
        }

        // GET: FarmersMarkets/Create
        public ActionResult Create()
        {
            ViewBag.GoogleMapId = new SelectList(db.GoogleMaps, "Id", "CurrentLocation");
            return View();
        }

        // POST: FarmersMarkets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FarmersMarketId,marketname,Schedule,Address,Products,ZipCode,GoogleMapId")] FarmersMarket farmersMarket)
        {
            if (ModelState.IsValid)
            {
                db.FarmersMarkets.Add(farmersMarket);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GoogleMapId = new SelectList(db.GoogleMaps, "Id", "CurrentLocation", farmersMarket.GoogleMapId);
            return View(farmersMarket);
        }

        // GET: FarmersMarkets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FarmersMarket farmersMarket = db.FarmersMarkets.Find(id);
            if (farmersMarket == null)
            {
                return HttpNotFound();
            }
            ViewBag.GoogleMapId = new SelectList(db.GoogleMaps, "Id", "CurrentLocation", farmersMarket.GoogleMapId);
            return View(farmersMarket);
        }

        // POST: FarmersMarkets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FarmersMarketId,marketname,Schedule,Address,Products,ZipCode,GoogleMapId")] FarmersMarket farmersMarket)
        {
            if (ModelState.IsValid)
            {
                db.Entry(farmersMarket).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GoogleMapId = new SelectList(db.GoogleMaps, "Id", "CurrentLocation", farmersMarket.GoogleMapId);
            return View(farmersMarket);
        }

        // GET: FarmersMarkets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FarmersMarket farmersMarket = db.FarmersMarkets.Find(id);
            if (farmersMarket == null)
            {
                return HttpNotFound();
            }
            return View(farmersMarket);
        }

        // POST: FarmersMarkets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FarmersMarket farmersMarket = db.FarmersMarkets.Find(id);
            db.FarmersMarkets.Remove(farmersMarket);
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
