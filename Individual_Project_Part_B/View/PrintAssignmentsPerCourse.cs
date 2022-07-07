using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Individual_Project_Part_B.View
{
    public class PrintAssignmentsPerCourse
    {
        public void PrintAssignmentPerCourse()
        {
            MyContext db = new MyContext();

            var Courses = db.Courses.Include(x => x.Assignments).ToList();

            foreach (var cou in db.Courses)
            {
                Console.WriteLine($"The Course {cou.Title} has these Assignments");

                foreach (var assignment in cou.Assignments)
                {
                    Console.WriteLine($"Title and Description are is: {assignment.Tile} {assignment.Description}");
                }
            }
        }
    }
}
