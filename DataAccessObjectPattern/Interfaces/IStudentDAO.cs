using DataAccessObjectPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjectPattern.Interfaces
{
    public interface IStudentDAO
    {
        List<Student> GetAllStudents();
        Student GetStudent(int rollNo);
        void UpdateStudentName(int rollNo, string name);
        void DeleteStudent(Student student);
    }
}
