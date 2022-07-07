using Individual_Project_Part_B.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.RepositoryServices
{
    public class AssignmentRepository
    {
        public void CreateAssignment(Assignment assignment)
        {
            using (MyContext db = new MyContext())
            {
                db.Entry(assignment).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public List<Assignment> GetAll()
        {
            using (MyContext db = new MyContext())
            {
                //return db.Assignments.ToList();
                return db.Assignments.SqlQuery("Select * from Assignments").ToList();
            }
        }
    }
}
