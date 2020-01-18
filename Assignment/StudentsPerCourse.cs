using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class StudentsPerCourse
    {
        // Fields & Properties
        Course Course;

        // Constructors
        public StudentsPerCourse(Course course, List<Student> students)
        {
            Course = course;
            course.Students = students;
            foreach (var item in students)
            {
                item.Courses.Add(course); // maybe
            }
        }
        // Methods
        public void Output()
        {
            Console.WriteLine("The students who took the " + Course.Title + " course are.");

            foreach (var item in Course.Students)
            {
                Console.Write("\t");
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine();
        }
    }
}
