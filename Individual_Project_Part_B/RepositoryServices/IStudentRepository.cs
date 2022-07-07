using Individual_Project_Part_B.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_B.RepositoryServices
{
    public interface IStudentRepository
    {
        List<Student> GetAll();

        Student CreateStudent(int id);

        void Add(Student student);
    }
}
