using Individual_Project_Part_B.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.ServicesInput
{
    public class InputCourse
    {
         public Course CreateCourse()
        {
            Console.WriteLine("ADDING A NEW COURSE...");
            Console.WriteLine("Type Title");
            string title = Console.ReadLine();
            Console.WriteLine("Type Type");
            string type = Console.ReadLine();
            Console.WriteLine("Type Stream");
            string stream = Console.ReadLine();

            return new Course(title, type, stream);
        }
    }
}
