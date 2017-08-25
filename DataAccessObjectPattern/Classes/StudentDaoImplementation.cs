using DataAccessObjectPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjectPattern.Classes
{
    public class StudentDaoImplementation : IStudentDAO
    {
        // List is working as a database
        List<Student> listStudents;

        public StudentDaoImplementation()
        {
            listStudents = new List<Student>();
            Student student1 = new Student("Alice", 0);
            Student student2 = new Student("Bob", 1);
            listStudents.Add(student1);
            listStudents.Add(student2);
        }

        public List<Student> GetAllStudents()
        {
            return listStudents;
        }

        public Student GetStudent(int rollNo)
        {
            return listStudents.Find(stu => (stu.RollNo == rollNo));
        }

        public void UpdateStudentName(int rollNo, string newName)
        {
            Student oldStudent = listStudents.Find(stu => (stu.RollNo == rollNo));
            string oldName = oldStudent.Name;
            oldStudent.Name = newName;
            Console.WriteLine(String.Format("Student: #{0} updated from {1} to {2} in database", rollNo, oldName, newName));
        }

        public void DeleteStudent(Student student)
        {
            listStudents.Remove(student);
            Console.WriteLine(String.Format("Student: #{0} deleted from database", student.RollNo));
        }
    }
}
