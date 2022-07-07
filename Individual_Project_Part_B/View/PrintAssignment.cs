using Individual_Project_Part_B.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.View
{
    public class PrintAssignment : IPrintAssignments
    {
        public void Print(Assignment assignment)
        {
            throw new NotImplementedException();
        }

        public void PrintAssignments(List<Assignment> assignments)
        {
            foreach (Assignment ass in assignments)
            {
                Console.WriteLine($"{ass.AssignmentId,-5} {ass.Tile} {ass.Description} {ass.OralMark} {ass.SubDateTime}");
            }
        }
    }
}
