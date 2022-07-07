using Individual_Project_Part_B.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.View
{
    public class PrintCourse : IPrintCourse
    {
        public void Print(Course course)
        {
            throw new NotImplementedException();
        }

        public void PrintCourses(List<Course> courses)
        {
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.CourseId,-5} {course.Title,-10} {course.Stream,-15} {course.StartDate,-20} {course.EndDate,-25}");
            }
        }
    }
}
