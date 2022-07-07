using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Individual_Project_Part_B.View
{
    public class PrintStudentPerAssignments
    {
        public void PrintStudentPerAssignment()
        {
            MyContext db = new MyContext();

            var Assignments = db.Assignments.Include(x => x.Students).ToList();
            
            foreach (var ass in db.Assignments)
            {
                Console.WriteLine($"The Assignment{ass.Tile} has the following Students");
                foreach (var student in ass.Students)
                {
                    Console.WriteLine($"\t\t\t with Fullnames {student.LastName} {student.FirstName}");
                }
            }
                

                          //db.Courses.Include(x => x.Students).ToList();
                //var students = db.Students.ToList().Where(s => s.Courses.Count() > 1);
                //foreach (var student in students)
                //{
                //    Console.WriteLine($"\t\t Student {student.FirstName,-10}\t{student.LastName,-10} has ({student.Courses.Count()}) courses ");
                //}
        }
    }
}
