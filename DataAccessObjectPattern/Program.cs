using DataAccessObjectPattern.Classes;
using DataAccessObjectPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentDAO studentDao = new StudentDaoImplementation();

            // Print all students
            foreach (Student student in studentDao.GetAllStudents())
            {
                Console.WriteLine(String.Format("Student: [Name: {0}, RollNo: {1}]", student.Name, student.RollNo));
            }

            // UpdateStudent
            Student studentToUpdate = studentDao.GetAllStudents()[0];
            studentDao.UpdateStudentName(studentToUpdate.RollNo, "Michael");

            // Get the student
            Student updatedStudent = studentDao.GetStudent(0);
            Console.WriteLine(String.Format("Student: [Name: {0}, RollNo: {1}]", updatedStudent.Name, updatedStudent.RollNo));

            Console.ReadLine();
        }
    }
}
