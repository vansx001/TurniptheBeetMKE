using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TurnipTheBeetMKE.Models;

namespace TurnipTheBeetMKE.Controllers
{
    public class GoogleMapsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GoogleMaps
        public async Task<ActionResult> Index()
        {
            return View(await db.GoogleMaps.ToListAsync());
        }

        // GET: GoogleMaps/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoogleMap googleMap = await db.GoogleMaps.FindAsync(id);
            if (googleMap == null)
            {
                return HttpNotFound();
            }
            return View(googleMap);
        }

        // GET: GoogleMaps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GoogleMaps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,CurrentLocation,Destination,Name,Address,Latitude,Longitude")] GoogleMap googleMap)
        {
            if (ModelState.IsValid)
            {
                db.GoogleMaps.Add(googleMap);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(googleMap);
        }

        // GET: GoogleMaps/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoogleMap googleMap = await db.GoogleMaps.FindAsync(id);
            if (googleMap == null)
            {
                return HttpNotFound();
            }
            return View(googleMap);
        }

        // POST: GoogleMaps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,CurrentLocation,Destination,Name,Address,Latitude,Longitude")] GoogleMap googleMap)
        {
            if (ModelState.IsValid)
            {
                db.Entry(googleMap).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(googleMap);
        }

        // GET: GoogleMaps/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoogleMap googleMap = await db.GoogleMaps.FindAsync(id);
            if (googleMap == null)
            {
                return HttpNotFound();
            }
            return View(googleMap);
        }

        // POST: GoogleMaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            GoogleMap googleMap = await db.GoogleMaps.FindAsync(id);
            db.GoogleMaps.Remove(googleMap);
            await db.SaveChangesAsync();
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
