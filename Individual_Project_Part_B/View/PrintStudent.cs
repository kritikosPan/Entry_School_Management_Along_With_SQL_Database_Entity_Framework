using Individual_Project_Part_B.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.View
{
    public class PrintStudent : IPrintStudent
    {
        public void Print(Student student)
        {
            throw new NotImplementedException();
        }

        public void PrintStudents(List<Student> students)
        {
            foreach (var stu in students)
            {
                Console.WriteLine();
                Console.WriteLine($"{stu.StudentId} {stu.FirstName} {stu.FirstName} {stu.DateOfBirth} {stu.TuitionFees}");
            }
        }
    }
}
