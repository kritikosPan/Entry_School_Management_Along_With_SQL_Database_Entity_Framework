using Individual_Project_Part_B.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.RepositoryServices
{
    public class CourseRepository
    {
        public void CreateCourse(Course course)
        {
            using (MyContext db = new MyContext())
            {
                db.Entry(course).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public List<Course> GetAll()
        {
            using (MyContext db = new MyContext())
            {
                //return db.Assignments.ToList();
                return db.Courses.SqlQuery("Select * from Courses").ToList();
            }
        }
    }
}
