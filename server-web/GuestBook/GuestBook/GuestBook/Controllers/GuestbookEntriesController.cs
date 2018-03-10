using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GuestBook.Models;

namespace GuestBook.Controllers
{
    public class GuestbookEntriesController : Controller
    {
        private GuestbookContext db = new GuestbookContext();

        // GET: GuestbookEntries
        public ActionResult Index()
        {
            return View(db.Entries.ToList());
        }

        // GET: GuestbookEntries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuestbookEntry guestbookEntry = db.Entries.Find(id);
            if (guestbookEntry == null)
            {
                return HttpNotFound();
            }
            return View(guestbookEntry);
        }

        // GET: GuestbookEntries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GuestbookEntries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Message,DateCreated")] GuestbookEntry guestbookEntry)
        {
            if (ModelState.IsValid)
            {
                db.Entries.Add(guestbookEntry);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(guestbookEntry);
        }

        // GET: GuestbookEntries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuestbookEntry guestbookEntry = db.Entries.Find(id);
            if (guestbookEntry == null)
            {
                return HttpNotFound();
            }
            return View(guestbookEntry);
        }

        // POST: GuestbookEntries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Message,DateCreated")] GuestbookEntry guestbookEntry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(guestbookEntry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(guestbookEntry);
        }

        // GET: GuestbookEntries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuestbookEntry guestbookEntry = db.Entries.Find(id);
            if (guestbookEntry == null)
            {
                return HttpNotFound();
            }
            return View(guestbookEntry);
        }

        // POST: GuestbookEntries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GuestbookEntry guestbookEntry = db.Entries.Find(id);
            db.Entries.Remove(guestbookEntry);
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
