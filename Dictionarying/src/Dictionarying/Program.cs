using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dictionarying
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newId;

            Console.WriteLine("Enter your student's ID (or ENTER to finish)");
            do
            {
                Console.Write("student ID: ");
                newId = Console.ReadLine();
                if (newId != "")
                {
                    int studentId = Int32.Parse(newId);
                    Console.Write("name: ");
                    string studentName = Console.ReadLine();

                    students.Add(studentId, studentName);
                }
            }
            while (newId != "");

            Console.WriteLine("\nSchool Roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + ": " + student.Value);

            }
            Console.ReadLine();
        }
    }
}
