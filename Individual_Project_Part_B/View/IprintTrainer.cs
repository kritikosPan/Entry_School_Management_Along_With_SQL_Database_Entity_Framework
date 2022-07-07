using Individual_Project_Part_B.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.View
{
    public interface IprintTrainer
    {
        void Print(Trainer trainer);

        void PrintTrainers(List<Trainer> trainers);
    }
}
