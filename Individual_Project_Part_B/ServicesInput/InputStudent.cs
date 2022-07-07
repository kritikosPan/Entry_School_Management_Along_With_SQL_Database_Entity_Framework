using Individual_Project_Part_B.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.ServicesInput
{
    public class InputStudent
    {
        public Student InputStudentData()
        {
            Console.WriteLine("ADDING A NEW STUDENT...");
            Console.WriteLine("Type First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Type Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Type Tuition Fees");
            int tuitionFees = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Type the Enrolled Course Title");
            //string courseTitle = Console.ReadLine();


            return new Student(firstName, lastName, tuitionFees);
        }
    }
}
