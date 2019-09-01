using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Giorgos_Rouselatos_Assignment_2.Models;

namespace Giorgos_Rouselatos_Assignment_2.Managers
{
    public class DbManager
    {
        public ICollection<Trainer> GetTrainers()
        {
            ICollection<Trainer> result;
            using (TrainerDb db = new TrainerDb())
            {
                result = db.Trainers.ToList();
            }
            return result;
        }

        public Trainer GetTrainer(int id)
        {
            Trainer result;
            using (TrainerDb db = new TrainerDb())
            {
                result = db.Trainers.Find(id);
            }
            return result;
        }

        public void AddTrainer(Trainer trainer)
        {
            using (TrainerDb db = new TrainerDb())
            {
                db.Trainers.Add(trainer);
                db.SaveChanges();
            }
        }

        public void UpdateTrainer(Trainer trainer)
        {
            using (TrainerDb db = new TrainerDb())
            {
                db.Trainers.Attach(trainer);
                db.Entry(trainer).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteTrainer(int id)
        {
            using (TrainerDb db = new TrainerDb())
            {
                Trainer trainer = db.Trainers.Find(id);
                db.Trainers.Remove(trainer);
                db.SaveChanges();
            }
        }
    }
}