using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using scoreboardVB10.Models;

namespace scoreboardVB10.Controllers
{
    public class ScoreboardVBModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ScoreboardVBModels
        public ActionResult Index()
        {
            return View(db.ScoreboardVBModels.ToList());
        }

        // GET: ScoreboardVBModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScoreboardVBModels scoreboardVBModels = db.ScoreboardVBModels.Find(id);
            if (scoreboardVBModels == null)
            {
                return HttpNotFound();
            }
            return View(scoreboardVBModels);
        }

        // GET: ScoreboardVBModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ScoreboardVBModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MatchName,HomeTeam,HomeTeamScore,GuestTeam,GuestTeamScore,Set1Winner,Set2Winner,Set3Winner,MatchDateTime,SetNumber")] ScoreboardVBModels scoreboardVBModels)
        {
            if (ModelState.IsValid)
            {
                db.ScoreboardVBModels.Add(scoreboardVBModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(scoreboardVBModels);
        }

        // GET: ScoreboardVBModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScoreboardVBModels scoreboardVBModels = db.ScoreboardVBModels.Find(id);
            if (scoreboardVBModels == null)
            {
                return HttpNotFound();
            }
            return View(scoreboardVBModels);
        }

        // POST: ScoreboardVBModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MatchName,HomeTeam,HomeTeamScore,GuestTeam,GuestTeamScore,Set1Winner,Set2Winner,Set3Winner,MatchDateTime,SetNumber")] ScoreboardVBModels scoreboardVBModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(scoreboardVBModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(scoreboardVBModels);
        }

        // GET: ScoreboardVBModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScoreboardVBModels scoreboardVBModels = db.ScoreboardVBModels.Find(id);
            if (scoreboardVBModels == null)
            {
                return HttpNotFound();
            }
            return View(scoreboardVBModels);
        }

        // POST: ScoreboardVBModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ScoreboardVBModels scoreboardVBModels = db.ScoreboardVBModels.Find(id);
            db.ScoreboardVBModels.Remove(scoreboardVBModels);
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
