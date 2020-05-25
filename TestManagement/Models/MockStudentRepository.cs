using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestManagement.Models
{
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _students;
        public MockStudentRepository()
        {
            _students = new List<Student>()
            {
                new Student{ Id=1,Name="张三",ClassName="一年级",Email="2503223134@qq.com"},
                new Student{ Id=2,Name="李四",ClassName="二年级",Email="13054119237@qq.com"},
                new Student{ Id=3,Name="王五",ClassName="三年级",Email="15096339906@qq.com"}
            };
        }
        public Student GetStudent(int id)
        {
            return _students.FirstOrDefault(e => e.Id == id);
        }
    }
}
