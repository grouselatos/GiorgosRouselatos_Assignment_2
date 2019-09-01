using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Giorgos_Rouselatos_Assignment_2.Models;
using Giorgos_Rouselatos_Assignment_2.Managers;

namespace Giorgos_Rouselatos_Assignment_2.Controllers
{
    public class TrainersController : Controller
    {
        // GET: Trainers
        private DbManager db = new DbManager();
        public ActionResult Index()
        {
            var Trainers = db.GetTrainers();
            return View(Trainers);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Trainer trainer)
        {
            if (!ModelState.IsValid)
            {
                return View(trainer);
            }
            db.AddTrainer(trainer);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Trainer trainer = db.GetTrainer(id);
            if(trainer == null)
            {
                return HttpNotFound();
            }
            return View(trainer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit (Trainer trainer)
        {
            if (!ModelState.IsValid)
            {
                return View(trainer);
            }
            db.UpdateTrainer(trainer);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Trainer trainer = db.GetTrainer(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }
            return View(trainer);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            db.DeleteTrainer(id);
            return RedirectToAction("Index");
        }
    }
}