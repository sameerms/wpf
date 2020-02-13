using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'StudentController'
    public class StudentController : ApiController
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'StudentController'
    {

        IList<Student> Students = new List<Student>()
        {
            new Student()
                {
                    StudentId = 1, StudentName = "Mukesh Kumar"   },
                new Student()
                {
                    StudentId = 2, StudentName = "Banky Chamber"
                },
                new Student()
                {
                    StudentId = 3, StudentName = "Rahul Rathor"
                },
                new Student()
                {
                    StudentId = 4, StudentName = "YaduVeer Singh"
                },
                new Student()
                {
                    StudentId = 5, StudentName = "Manish Sharma"
                },
        };
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'StudentController.GetAllStudents()'
        public IList<Student> GetAllStudents()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'StudentController.GetAllStudents()'
        {
            //Return list of all Students  
            return Students;
        }
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'StudentController.GetStudentDetails(int)'
        public Student GetStudentDetails(int id)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'StudentController.GetStudentDetails(int)'
        {
            //Return a single Student detail  
            var Student = Students.FirstOrDefault(e => e.StudentId == id);
            if (Student == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return Student;
        }
    }
}
