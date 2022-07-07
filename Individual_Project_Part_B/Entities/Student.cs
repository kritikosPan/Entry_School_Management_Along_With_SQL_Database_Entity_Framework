using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.Entities
{
    public class Student
    {   
        public Student() { }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int TuitionFees { get; set; }

        // Navigation Properties
        public Course Course { get; set; }

        //Foreign Key
        public int? CourseId { get; set; }
        
        public Student (string firstName, string lastName, DateTime dateOfBirth, int tuitionFees)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TuitionFees = tuitionFees;
        }

        public Student(string firstName, string lastName, int tuitionFees)// string courseTitle)
        {
            FirstName = firstName;
            LastName = lastName;
            TuitionFees = tuitionFees;
            //Course.Title = courseTitle;
        }

        //public virtual ICollection<Course> Courses { get; set; } //navigation property

        public virtual ICollection<Assignment> Assignments { get; set; } //navigation property

    }


}
