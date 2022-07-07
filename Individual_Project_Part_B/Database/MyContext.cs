using Individual_Project_Part_B.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B
{
    public class MyContext : DbContext
    {
        public MyContext() : base("Sindesmos")
        {

        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

    }
}
