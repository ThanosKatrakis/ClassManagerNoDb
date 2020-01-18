using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class TrainersPerCourse
    {
        // Fields & Properties
        Course Course;

        // Constructors
        public TrainersPerCourse(Course course, List<Trainer> trainers)
        {
            Course = course;
            course.Trainers = trainers;
            foreach (var item in trainers)
            {
                item.Courses = course;
            }
        }

        // Methods
        public void Output()
        {
            Console.WriteLine("The trainers who teach the " + Course.Title + " course are.");

            foreach (var item in Course.Trainers)
            {
                Console.Write("\t");
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine();
        }
    }
}
