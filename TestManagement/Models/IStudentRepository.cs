using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestManagement.Models
{
    public interface IStudentRepository
    {
        Student GetStudent(int id);
    }
}
