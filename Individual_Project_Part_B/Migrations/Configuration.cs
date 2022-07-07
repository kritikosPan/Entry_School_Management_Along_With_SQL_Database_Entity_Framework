namespace Individual_Project_Part_B.Migrations
{
    using Individual_Project_Part_B.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Individual_Project_Part_B.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Individual_Project_Part_B.MyContext context)
        {
            #region Courses_SyntheticData

            
            Course c1 = new Course("CB1", "Full-Time", "C#", DateTime.UtcNow, DateTime.Now);
            Course c2 = new Course("CB2", "Full-Time", "Python", DateTime.UtcNow, DateTime.Now);
            Course c3 = new Course("CB3", "Full-Time", "F#", DateTime.UtcNow, DateTime.Now);
            Course c4 = new Course("CB4", "Part-Time", "Objective C", DateTime.UtcNow, DateTime.Now);
            Course c5 = new Course("CB5", "Part-Time", "Visual Basic", DateTime.UtcNow, DateTime.Now);

            //context.Courses.AddOrUpdate(c => c.Title, c1, c2, c3, c4);
            context.Courses.Add(c1);
            context.Courses.Add(c2);
            context.Courses.Add(c3);
            context.Courses.Add(c4);
            context.Courses.Add(c5);

            context.SaveChanges();
            #endregion

            #region Trainers_SyntheticData

            
            Trainer t1 = new Trainer("Agelos", "Basinas", "Sql Databases");
            Trainer t2 = new Trainer("Carlos", "Zeka", "Object Orineted Programming");
            Trainer t3 = new Trainer("Gilberto", "Silva", "ASP .NET");
            Trainer t4 = new Trainer("Konstantinos", "Katsouranis", "Web Applications");
            Trainer t5 = new Trainer("Marcelo", "Matos", "Desktop Application");
            Trainer t6 = new Trainer("Sebastian", "Leto", "Mobile Application");
            Trainer t7 = new Trainer("Georgios", "Karagounis", "Pure Coding");
            Trainer t8 = new Trainer("Dimitrios", "Kourbellis", "Front-End Development");

            //context.Trainers.AddOrUpdate(t => t.FirstName, t1, t2, t3, t4, t5, t6, t7, t8);
            context.Trainers.Add(t1);
            context.Trainers.Add(t2);
            context.Trainers.Add(t3);
            context.Trainers.Add(t4);
            context.Trainers.Add(t5);
            context.Trainers.Add(t6);
            context.Trainers.Add(t7);
            context.Trainers.Add(t8);
            context.SaveChanges();
            #endregion

            #region Students_SyntheticData

            
            Student s1 = new Student("Sotirios", "Alexandropoulos", DateTime.UtcNow, 1000);
            Student s2 = new Student("Ioannis", "Goumas", DateTime.UtcNow, 1500);
            Student s3 = new Student("Sotiris", "Leodiou", DateTime.UtcNow, 2000);
            Student s4 = new Student("Juan Ramon", "Rottha", DateTime.UtcNow, 2500);
            Student s5 = new Student("Jonas", "Kolka", DateTime.UtcNow, 3000);
            Student s6 = new Student("Raymond", "Zutaoutas", DateTime.UtcNow, 3500);
            Student s7 = new Student("Alexanros", "Tzorvas", DateTime.UtcNow, 4000);
            Student s8 = new Student("Orestis", "Karnezis", DateTime.UtcNow, 5000);
            Student s9 = new Student("Christof", "Vartzhycha", DateTime.UtcNow, 100);
            Student s10 = new Student("Loukas", "Vyntra", DateTime.Now, 1000);
            Student s11 = new Student("Sokratis", "Dioudis", DateTime.Now, 1000);
            Student s12 = new Student("Alberto", "Brinioli", DateTime.Now, 1500);
            Student s13 = new Student("Bart", "Sheckefeld", DateTime.Now, 1200);
            Student s14 = new Student("Ruben", "Sanchez", DateTime.Now, 1300);
            Student s15 = new Student("Ioannis", "Vagiannidis", DateTime.Now, 1400);
            Student s16 = new Student("Ruben", "Perez", DateTime.Now, 1500);
            Student s17 = new Student("Luca", "Villafaniez", DateTime.Now, 1600);
            Student s18 = new Student("Aitor", "Calaptaprieda", DateTime.Now, 1700);
            Student s19 = new Student("Fotios", "Ioannidis", DateTime.Now, 1800);
            Student s20 = new Student("Sebastian", "Palasios", DateTime.Now, 1900);

            //context.Students.AddOrUpdate(s => s.FirstName, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20);
            context.Students.Add(s1);
            context.Students.Add(s2);
            context.Students.Add(s3);
            context.Students.Add(s4);
            context.Students.Add(s5);
            context.Students.Add(s6);
            context.Students.Add(s7);
            context.Students.Add(s8);
            context.Students.Add(s9);
            context.Students.Add(s10);
            context.Students.Add(s11);
            context.Students.Add(s12);
            context.Students.Add(s13);
            context.Students.Add(s14);
            context.Students.Add(s15);
            context.Students.Add(s16);
            context.Students.Add(s17);
            context.Students.Add(s18);
            context.Students.Add(s19);
            context.Students.Add(s20);
            context.SaveChanges();
            #endregion

            #region Assignments_SyntheticData

            
            Assignment a1 = new Assignment("Assignment_1", "Group", DateTime.Now, 40, 80);
            Assignment a2 = new Assignment("Assignment_2", "Group", DateTime.Now, 50, 80);
            Assignment a3 = new Assignment("Assignment_3", "Group", DateTime.Now, 50, 80);
            Assignment a4 = new Assignment("Assignment_4", "Group", DateTime.Now, 50, 80);
            Assignment a5 = new Assignment("Assignment_5", "Group", DateTime.Now, 50, 80);
            Assignment a6 = new Assignment("Individual Project Part_A", "Individual", DateTime.Now, 50, 80);
            Assignment a7 = new Assignment("Individual Project Part_B", "Individual", DateTime.Now, 50, 80);

            //context.Assignments.AddOrUpdate(a => a.Tile, a1, a2, a3, a4, a5, a6, a7);
            context.Assignments.Add(a1);
            context.Assignments.Add(a2);
            context.Assignments.Add(a3);
            context.Assignments.Add(a4);
            context.Assignments.Add(a5);
            context.Assignments.Add(a6);
            context.Assignments.Add(a7);
            context.SaveChanges();
            #endregion

            #region StudentsPerCourse

            c1.Students = new List<Student>{ s1, s2, s3, s4, s5 };
            c2.Students = new List<Student>{ s6, s7, s8, s9, s10 };
            c3.Students = new List<Student>{ s11, s12, s13};
            c4.Students = new List<Student>{ s14, s15, s16, s17, s18, s19, s20 };

            context.Courses.AddOrUpdate(c1, c2, c3, c4);

            s1.Course = c1;
            s2.Course = c1;
            s3.Course = c1;
            s4.Course = c1;
            s5.Course = c1;
            s6.Course = c2;
            s7.Course = c2;
            s8.Course = c2;
            s9.Course = c2;
            s10.Course = c2;
            s11.Course = c3;
            s12.Course = c3;
            s13.Course = c3;
            s14.Course = c4;
            s15.Course = c4;
            s16.Course = c4;
            s17.Course = c4;
            s18.Course = c4;
            s19.Course = c4;
            s20.Course = c4;
            
            context.SaveChanges();


            #endregion

            #region TrainerPerCourse

            c1.Trainers = new List<Trainer> { t7, t8 };
            c2.Trainers = new List<Trainer> { t5, t6 };
            c3.Trainers = new List<Trainer> { t3, t4 };
            c4.Trainers = new List<Trainer> { t1, t2 };

            context.Courses.AddOrUpdate(c1, c2, c3, c4);


            t1.Course = c4;
            t2.Course = c4;
            t3.Course = c3;
            t4.Course = c3;
            t5.Course = c2;
            t6.Course = c2;
            t7.Course = c1;
            t8.Course = c1;

            context.SaveChanges();

            #endregion

            #region AssignmentPerCourse 

            c1.Assignments = new List<Assignment> {a1, a2 };
            c2.Assignments = new List<Assignment> {a3, a6 };
            c3.Assignments = new List<Assignment> {a7, a4 };
            c4.Assignments = new List<Assignment> {a5 };

            context.Courses.AddOrUpdate(c1, c2, c3, c4);


            a1.Course = c1;
            a2.Course = c1;
            a3.Course = c2;
            a4.Course = c3;
            a5.Course = c4;
            a6.Course = c2;
            a7.Course = c3;

            context.SaveChanges();
            #endregion

            #region StudentsCourses

            //s1.Assignments.Add(a1);
            //s1.Assignments.Add(a2);
            //s1.Assignments.Add(a3);
            //s1.Assignments.Add(a4);
            //s1.Assignments.Add(a5);
            //s1.Assignments.Add(a6);
            s1.Assignments = new List<Assignment> { a1, a2, a3, a4, a5, a6};
            
            a1.Students = new List<Student> { s1, s2 };
            a2.Students = new List<Student> { s1, s2 };
            a3.Students = new List<Student> { s1, s2 };
            a4.Students = new List<Student> { s1, s2 };
            a5.Students = new List<Student> { s1, s2 };
            a6.Students = new List<Student> { s1, s2 };



            //a1.Students.Add(s1);
            //a2.Students.Add(s1);
            //a3.Students.Add(s1);
            //a4.Students.Add(s1);
            //a5.Students.Add(s1);
            //a6.Students.Add(s1);

            //

            s2.Assignments = new List<Assignment> { a1, a2, a3, a4, a5, a6 };

            a1.Students = new List <Student> { s1, s2 };
            a2.Students = new List <Student> { s1, s2 };
            a3.Students = new List <Student> { s1, s2 };
            a4.Students = new List <Student> { s1, s2 };
            a5.Students = new List <Student> { s1, s2 };
            a6.Students = new List <Student> { s1, s2 };
            //s2.Assignments.Add(a1);
            //s2.Assignments.Add(a2);
            //s2.Assignments.Add(a3);
            //s2.Assignments.Add(a4);
            //s2.Assignments.Add(a5);
            //s2.Assignments.Add(a7);


            //a1.Students.Add(s2);
            //a2.Students.Add(s2);
            //a3.Students.Add(s2);
            //a4.Students.Add(s2);
            //a5.Students.Add(s2);
            //a6.Students.Add(s2);


            context.Students.AddOrUpdate(s1, s2);
            context.Assignments.AddOrUpdate(a1, a2, a3, a4, a5, a6);
            

            context.SaveChanges();
            
            #endregion






        }
    }
}
