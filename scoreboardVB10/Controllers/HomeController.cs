using scoreboardVB10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System.Data.Entity;

namespace scoreboardVB10.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        //private SimpleHub sHub = new SimpleHub();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult HomeTest()
        {
            ViewBag.Message = "Your HomeTest page.";

            return View(db.ScoreboardVBModels.ToList());
        }

        // GET: Home/Score/5
        public ActionResult Score(int? id)
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

        // GET: Home/KeepScore/5
        public ActionResult KeepScore(int? id)
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

        // POST: Home/KeepScore/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KeepScore([Bind(Include = "Id,MatchName,HomeTeam,HomeTeamScore,GuestTeam,GuestTeamScore,Set1Winner,Set2Winner,Set3Winner,MatchDateTime,SetNumber")] ScoreboardVBModels scoreboardVBModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(scoreboardVBModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(scoreboardVBModels);
        }

        public ActionResult Entity()
        {
            ViewBag.red = "You get what you give.";
            
            var list = db.ScoreboardVBModels;
            return View(list);
        }
    }
}