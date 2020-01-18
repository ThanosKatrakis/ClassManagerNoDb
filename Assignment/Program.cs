using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            db.PrintAllStudents();
            db.PrintAllTrainers();
            db.PrintAllAssignment();
            db.PrintAllCourses();
            db.PrintStudentsPerCourse();
            db.PrintTrainersPerCourse();
            db.PrintAllAssignmentsPerCourse();
            db.printStudentsWithMoreThanOne();


            Console.ReadKey();
        }
    }

}
