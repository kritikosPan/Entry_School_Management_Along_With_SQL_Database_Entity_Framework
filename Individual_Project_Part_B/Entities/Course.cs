using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Stream { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // Navigation Properties
        public ICollection<Student> Students { get; set; }
        public ICollection<Trainer> Trainers { get; set; }
        public ICollection<Assignment> Assignments { get; set; }

        public Course()
        {
                
        }

        public Course(string title, string type, string stream, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Type = type;
            Stream = stream;
            StartDate = startDate;
            EndDate = endDate;
        }

        public Course(string title, string type, string stream)
        {
            Title = title;
            Type = type;
            Stream = stream;
        }
    }

    
}
