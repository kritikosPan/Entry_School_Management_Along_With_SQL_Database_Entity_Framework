using Individual_Project_Part_B.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Individual_Project_Part_B.Run
{
    public class MainController
    {
        // Building the Menu

        public void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Pick one of the Options given below");
            Console.WriteLine("===================================");
            Console.WriteLine("***********************************");
            Console.WriteLine("1 - Print All Students");
            Console.WriteLine("2 - Print All Trainers");
            Console.WriteLine("3 - Print All Assignments");
            Console.WriteLine("4 - Print All Courses");
            Console.WriteLine("5 - Print Students per Course");
            Console.WriteLine("6 - Print Trainers per Course");
            Console.WriteLine("7 - Print Assignments per Course");
            Console.WriteLine("8 - Print Assignments per Course per Student");
            Console.WriteLine("9 - Print Students which are enrolled in Many Assignments");
            Console.WriteLine("===================================");
            Console.WriteLine("***********************************");
            Console.WriteLine("10 - Create New Student");
            Console.WriteLine("11 - Create New Trainers");
            Console.WriteLine("12 - Create New Assignment");
            Console.WriteLine("13 - Create New Course");
            Console.WriteLine("14 - Add Student per Course");
            Console.WriteLine("15 - Add Trainer per Course");
            Console.WriteLine("16 - Add Assignment per Student per Course");

            Services services = new Services();
            bool start = false;
            do
            {
                int input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Option option = (Option)input;
                switch (option)
                {
                    case Option.PrintStudents: services.PrintStudents(); break;
                    case Option.PrintTrainers: services.PrintTrainers(); break;
                    case Option.PrintAssignments: services.PrintAssignments(); break;
                    case Option.PrintCourses: services.PrintCourses(); break;
                    case Option.PrintStudentsPerCourse: services.PrintStudentsPerCourse(); break;
                    case Option.PrintTrainersPerCourse: services.PrintTrainersPerCourse(); break;
                    case Option.PrintAssignmentsPerCourse: services.PrintAssignmentsPerCourse(); break;
                    case Option.PrintAssignmentPerCoursePerStudent: services.PrintAssignmentsPerCoursePerStudent(); break;
                    case Option.PrintStudentsBelongToMoreThanOneAssignments: services.PrintStudentPerAssignments(); break;
                    case Option.CreateStudent: services.CreateStudent(); break;
                    case Option.CreateTrainer: services.CreateTrainer(); break;
                    case Option.CreateAssignment: services.CreateAssignment(); break;
                    case Option.CreateCourse: services.CreateCourse(); break;
                    case Option.AddStudentPerCourse: services.AddStudentPerCourse(); break;
                    case Option.AddTrainerPerCourse: services.AddTrainerPerCourse(); break;
                    case Option.AddAssignmentPerStudentPerCourse: services.AddAssignmentPerStudentPerCourse(); break;
                    default: break;
                    
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("For Exit PRESS    x    OR    X");
                string exit = Console.ReadLine();
                if (exit.ToUpper() == "X") { start = true; } else { start = false; };
                Console.Clear();
            }
            while (start);
        } 

    }
}
