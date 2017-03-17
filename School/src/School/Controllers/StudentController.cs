using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace School.Controllers
{
    public class StudentController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public class Student
        {

            public string Name { get; set; }
            public int StudentId { get; set; }
            private int NumberOfCredits { get; set; }
            private double Gpa { get; set; }

            public Student(string name, int studentId, int numberOfCredits, double gpa)
            {
                Name = name;
                StudentId = studentId;
                NumberOfCredits = numberOfCredits;
                Gpa = gpa;
            }
            public Student(string name, int studentId)
            {
                Name = name;
                StudentId = studentId;
                NumberOfCredits = 0;
                Gpa = 0.0;
            }
            public void AddGrade(int courseCredits, double grade)
            {
                // Update the appropriate properties: NumberOfCredits, Gpa
            }

            public string GetGradeLevel()
            {
                // Determine the grade level of the student based on NumberOfCredits
            }
        }
        public class Course
        {
            string subject;
            int section;
            string description;
            int numberOfCredits;

            public string Subject { get; set; }
            public int Section { get; set; }
            public string Description { get; set; }
            public int NumberOfCredits { get; set; }
        }
  
    }
}
