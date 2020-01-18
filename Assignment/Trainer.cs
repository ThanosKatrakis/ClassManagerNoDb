using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Trainer
    {
        // Fields & Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Subject { get; set; }

        public Course Courses { get; set; }

        // Constructors
        public Trainer(string firstName, string lastName, string subject)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Subject = subject;
        }

        // Methods
        public void Output()
        {
            Console.WriteLine("First name: {0}", FirstName);
            Console.WriteLine("Last name: {0}", LastName);
            Console.WriteLine("His subject is: {0}", Subject);
            Console.WriteLine("");
        }
    }
}
