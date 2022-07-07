using Individual_Project_Part_B.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.View
{
    public class PrintTrainer : IprintTrainer
    {
        public void Print(Trainer trainer)
        {
            throw new NotImplementedException();
        }

        public void PrintTrainers(List<Trainer> trainers)
        {
            foreach (Trainer tr in trainers)
            {
                Console.WriteLine();
                Console.WriteLine($"{tr.TrainerId,-5} {tr.FirstName,-10} {tr.LastName,-15} {tr.Subject,-20}");
            }
        }
    }
}
