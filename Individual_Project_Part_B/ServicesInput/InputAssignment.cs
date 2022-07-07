using Individual_Project_Part_B.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.ServicesInput
{
    public class InputAssignment
    {
        public Assignment CreateAssignment()
        {
            Console.WriteLine("ADDING A NEW ASSIGNMENT...");
            Console.WriteLine("Type Title");
            string tile = Console.ReadLine();
            Console.WriteLine("Type Description");
            string description = Console.ReadLine();
            Console.WriteLine("Type the Oral Mark");
            int oralMark = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Type the Paper Mark");
            int paperMark = Int32.Parse(Console.ReadLine());


            return new Assignment(tile, description, oralMark, paperMark);
        }
    }
}
