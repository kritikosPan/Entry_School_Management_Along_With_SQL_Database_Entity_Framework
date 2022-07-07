using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.Entities
{
    public class Trainer
    {   
        public Trainer()
        {
        }

        public Trainer(string firstName, string lastName, string subject)
        {   
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        public int TrainerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        // Navigation Properties
        public Course Course { get; set; }

        //Foreign Key
        public int? CourseId { get; set; }
    }
}
