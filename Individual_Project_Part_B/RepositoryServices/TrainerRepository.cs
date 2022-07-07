using Individual_Project_Part_B.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.RepositoryServices
{
    public class TrainerRepository
    {
        public void CreateTrainer(Trainer trainer)
        {

            using (MyContext db = new MyContext())
            {
                db.Entry(trainer).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public List<Trainer> GetAll()
        {
            using (MyContext db = new MyContext())
            {
                return db.Trainers.ToList();
                //return db.Trainers.SqlQuery("Select * from Trainers").ToList();
            }
        }
    }
}
