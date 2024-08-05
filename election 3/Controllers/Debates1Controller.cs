﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using election_3.Models;

namespace election_3.Controllers
{
    public class Debates1Controller : Controller
    {
        private electionEntities2 db = new electionEntities2();

        // GET: Debates1
        public ActionResult Index()
        {
            return View(db.Debates.ToList());
        }

        // GET: Debates1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Debates debates = db.Debates.Find(id);
            if (debates == null)
            {
                return HttpNotFound();
            }
            return View(debates);
        }

        // GET: Debates1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Debates1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DebateID,DebateTitle,DebateDate,Location,Candidate1ID,Candidate2ID,Description,Status")] Debates debates)
        {
            if (ModelState.IsValid)
            {
                db.Debates.Add(debates);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(debates);
        }

        // GET: Debates1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Debates debates = db.Debates.Find(id);
            if (debates == null)
            {
                return HttpNotFound();
            }
            return View(debates);
        }

        // POST: Debates1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DebateID,DebateTitle,DebateDate,Location,Candidate1ID,Candidate2ID,Description,Status")] Debates debates)
        {
            if (ModelState.IsValid)
            {
                db.Entry(debates).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(debates);
        }

        // GET: Debates1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Debates debates = db.Debates.Find(id);
            if (debates == null)
            {
                return HttpNotFound();
            }
            return View(debates);
        }

        // POST: Debates1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Debates debates = db.Debates.Find(id);
            db.Debates.Remove(debates);
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
