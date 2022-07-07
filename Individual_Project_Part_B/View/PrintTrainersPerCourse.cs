using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Individual_Project_Part_B.View
{
    public class PrintTrainersPerCourse
    {
        public void PrintTrainerPerCourse()
        {
            MyContext db = new MyContext();

            var Courses = db.Courses.Include(x => x.Trainers).ToList();

            foreach (var cou in db.Courses)
            {
                Console.WriteLine($"The Course {cou.Title} has these Trainers");

                foreach (var trainer in cou.Trainers)
                {
                    Console.WriteLine($"Fullname is: {trainer.FirstName} {trainer.LastName}");
                }
            }
        }
    }
}
