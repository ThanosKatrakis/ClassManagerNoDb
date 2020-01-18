using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class AssignmentsPerCourse
    {
        // Fields & Properties
        Course Course;

        // Constructors
        public AssignmentsPerCourse(Course course, List<Assignment> assignments)
        {
            Course = course;
            course.Assigments = assignments;
            foreach (var item in assignments)
            {
                item.Courses = course;
            }
        }

        // Methods
        public void Output()
        {
            Console.WriteLine(Course.Title + " got those assignments.");

            foreach (var item in Course.Assigments)
            {
                Console.WriteLine(item.Title);
            }

            Console.WriteLine();
        }
    }
}
