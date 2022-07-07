using Individual_Project_Part_B.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.ServicesInput
{
    public class InputTrainer
    {
        public Trainer CreateTrainer()
        {
            Console.WriteLine("ADDING A NEW TRAINER...");
            Console.WriteLine("Type First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Type Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Type the Enrolled Course Title");
            string subject = Console.ReadLine();


            return new Trainer(firstName, lastName, subject);
        } 
    }
}
