using MVVMFlyout.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFlyout.Services
{
    internal class StudentStore 
    {
        private Student student;

        public async Task<bool> AddStudent(Student _student)
        {
            student = _student;

            return await Task.FromResult(true);
        }

        public async Task<Student> GetStudentAsync()
        {
            /*Student student = new Student();
            student.FirstName = "Jane";
            student.LastName = "Wilson";
            student.Country = "Greenland";
            student.Language = "English (United Kingdom)";*/
            return await Task.FromResult(student);
        }
    }
}
