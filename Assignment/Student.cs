using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Student
    {
        // Fields & Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfbirth { get; set; } = new DateTime();
        public int TuitionFees { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        
        // Constructors
        public Student(string firstName, string lastName, DateTime dateOfBirth, int tuitionFees)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfbirth = dateOfBirth;
            this.TuitionFees = tuitionFees;
        }

        // Methods
        public void Output()
        {
            Console.WriteLine("First name: {0}", FirstName);
            Console.WriteLine("Last name: {0}", LastName);
            Console.WriteLine("Birth date is: {0}", DateOfbirth.ToString("MM/dd/yyyy"));
            Console.WriteLine("Tuition fees are: {0}", TuitionFees);
            Console.WriteLine("");
        }

        

        
    }
}
