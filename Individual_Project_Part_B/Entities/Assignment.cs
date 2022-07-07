using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.Entities
{
    public class Assignment
    {   
        public Assignment() 
        {
        }

        public int AssignmentId { get; set; }
        public string Tile { get; set; }
        public string Description { get; set; }
        public DateTime? SubDateTime { get; set; }
        public int OralMark { get; set; }
        public int PaperMark { get; set; }
        //public int TotalMark { get; set; }

        // Navigation Properties
        public Course Course { get; set; }

        //Foreign Key
        public int? CourseId { get; set; }

        public Assignment(string tile, string description, DateTime subDateTime, int oralMark, int paperMark)
        {
            Tile = tile;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            PaperMark = paperMark;
        }

        public Assignment(string tile, string description, int oralMark, int paperMark)
        {
            Tile = tile;
            Description = description;
            //SubDateTime = subDateTime;
            OralMark = oralMark;
            PaperMark = paperMark;
        }

        public virtual ICollection<Student> Students { get; set; } //navigation property
        //public virtual ICollection<Course> Courses { get; set; } //navigation property
    }
}
