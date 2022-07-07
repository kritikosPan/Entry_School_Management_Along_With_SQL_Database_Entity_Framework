using Individual_Project_Part_B.RepositoryServices;
using Individual_Project_Part_B.ServicesInput;
using Individual_Project_Part_B.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.Run
{
    public class Services
    {   
        MyContext context = new MyContext();

        public void PrintStudents()
        {
            try
            {
                StudentRepository rep = new StudentRepository();
                PrintStudent pr = new PrintStudent();

                var students = rep.GetAll();
                pr.PrintStudents(students);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintTrainers()
        {
            try
            {
                TrainerRepository rep = new TrainerRepository();
                PrintTrainer pr = new PrintTrainer();

                var trainers = rep.GetAll();
                pr.PrintTrainers(trainers);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void PrintAssignments()
        {
            try
            {
                AssignmentRepository assignmentRepository = new AssignmentRepository();
                PrintAssignment pr = new PrintAssignment();

                var assignments = assignmentRepository.GetAll();
                pr.PrintAssignments(assignments);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void PrintCourses()
        {
            try
            {
                CourseRepository courseRepository = new CourseRepository();
                PrintCourse pr = new PrintCourse();

                var courses = courseRepository.GetAll();
                pr.PrintCourses(courses);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintStudentsPerCourse()
        {
            try
            {
                PrintStudentsPerCourse studentsPerCourse = new PrintStudentsPerCourse();
                
                studentsPerCourse.PrintStudentsperCourse();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public void PrintTrainersPerCourse()
        {
            try
            {
                PrintTrainersPerCourse trainerPerCourse = new PrintTrainersPerCourse();
                trainerPerCourse.PrintTrainerPerCourse();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public void PrintAssignmentsPerCourse()
        {
            try
            {
                PrintAssignmentsPerCourse pr = new PrintAssignmentsPerCourse();
                pr.PrintAssignmentPerCourse();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void PrintAssignmentsPerCoursePerStudent()
        {
            try
            {
                PrintAssignmentPerCoursePerStudent pr = new PrintAssignmentPerCoursePerStudent();
                pr.PrintAssignmentStudentCourse();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void PrintStudentPerAssignments()
        {
            try
            {
                PrintStudentPerAssignments pr = new PrintStudentPerAssignments();
                pr.PrintStudentPerAssignment();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CreateStudent()
        {
            try
            {
                StudentRepository rep = new StudentRepository();
                InputStudent inp = new InputStudent();

                var student = inp.InputStudentData();
                rep.CreateStudent(student);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CreateTrainer()
        {
            try
            {
                TrainerRepository rep = new TrainerRepository();
                InputTrainer inp = new InputTrainer();

                var trainer = inp.CreateTrainer();
                rep.CreateTrainer(trainer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CreateAssignment()
        {
            try
            {
                AssignmentRepository rep = new AssignmentRepository();
                InputAssignment inp = new InputAssignment();

                var assignment = inp.CreateAssignment();
                rep.CreateAssignment(assignment);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void CreateCourse()
        {
            try
            {
                CourseRepository rep = new CourseRepository();
                InputCourse inp = new InputCourse();

                var course = inp.CreateCourse();
                rep.CreateCourse(course);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void AddStudentPerCourse()
        {
            throw new NotImplementedException();
        }

        public void AddTrainerPerCourse()
        {
            throw new NotImplementedException();
        }

        public void AddAssignmentPerStudentPerCourse()
        {
            throw new NotImplementedException();
        }

        public void DefaultMessage()
        {
            Console.WriteLine("Wrong Choice - See Above");
        }
    }

}
