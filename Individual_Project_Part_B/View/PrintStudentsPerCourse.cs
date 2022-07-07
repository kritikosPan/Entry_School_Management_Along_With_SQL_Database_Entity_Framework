using Individual_Project_Part_B.Entities;
using Individual_Project_Part_B.RepositoryServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Individual_Project_Part_B.View
{
    public class PrintStudentsPerCourse
    {
        public void PrintStudentsperCourse() {

            MyContext db = new MyContext();

            var Courses = db.Courses.Include(x => x.Students).ToList();

            foreach (var cou in db.Courses)
            {
                Console.WriteLine($"The Course {cou.Title} has these Students");
                
                foreach (var student in cou.Students)
                {
                    Console.WriteLine($"Fullname is: {student.FirstName} {student.LastName}");
                }
            }
        } 
    }
}
