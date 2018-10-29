using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarLotDB.Models;

namespace CarLotDB.Controllers
{
    public class VehicleTypesController : Controller
    {
        private CarDB db = new CarDB();

        // GET: VehicleTypes
        public ActionResult Index()
        {
            return View(db.VehicleTypes.ToList());
        }

        // GET: VehicleTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleTypes vehicleTypes = db.VehicleTypes.Find(id);
            if (vehicleTypes == null)
            {
                return HttpNotFound();
            }
            return View(vehicleTypes);
        }

        // GET: VehicleTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type")] VehicleTypes vehicleTypes)
        {
            if (ModelState.IsValid)
            {
                db.VehicleTypes.Add(vehicleTypes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vehicleTypes);
        }

        // GET: VehicleTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleTypes vehicleTypes = db.VehicleTypes.Find(id);
            if (vehicleTypes == null)
            {
                return HttpNotFound();
            }
            return View(vehicleTypes);
        }

        // POST: VehicleTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Type")] VehicleTypes vehicleTypes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicleTypes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehicleTypes);
        }

        // GET: VehicleTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleTypes vehicleTypes = db.VehicleTypes.Find(id);
            if (vehicleTypes == null)
            {
                return HttpNotFound();
            }
            return View(vehicleTypes);
        }

        // POST: VehicleTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VehicleTypes vehicleTypes = db.VehicleTypes.Find(id);
            db.VehicleTypes.Remove(vehicleTypes);
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
