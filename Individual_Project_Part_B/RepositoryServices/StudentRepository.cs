using Individual_Project_Part_B.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.RepositoryServices
{
    public class StudentRepository
    {
        public void CreateStudent(Student student)
        {
            using (MyContext db = new MyContext())
            {
                db.Entry(student).State = EntityState.Added;
                db.SaveChanges();
            }
                
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            using (MyContext db = new MyContext())
            {
                //return db.Students.ToList();
                return db.Students.SqlQuery("Select * from Students").ToList();
            }
        }
    }
}
