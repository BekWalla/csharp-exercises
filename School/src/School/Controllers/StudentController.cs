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
                double gpa = Gpa.Student;
                double numberOfCredits = Value.NumberOfCredits;
                double totalQualityScore = (gpa * numberOfCredits);
                double qualityScore = (grade * courseCredits);
                totalQualityScore = (totalQualityScore + qualityScore);
                numberOfCredits = (numberOfCredits + courseCredits);
                numberOfCredits = 
                gpa = (totalQualityScore / numberofCredits);
                gpa = set Student.Gpa()
            }
            public string GetGradeLevel()
            {
                numberOfCredits = get Student.NumberOfCredits();
                if (numberOfCredits < 30)
                {
                    return "Freshman"
                }
                if (numberOfCredits > 29 && numberOfCredits < 60)
                {
                    return "Sophomore"
                }
                if (numberOfCredits > 59 && numberOfCredits < 90)
                {
                    return "Junior"
                }
                if (numberOfCredits > 89
                {
                    return "Senior"
                }
            }

            public override String ToString()
            {
                return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
            }

            public override bool Equals(object obj)
            {
                Student other = obj as Student;
                return other.StudentId == StudentId;
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
