using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Course
    {
        // Fields & Properties
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; } = new DateTime();
        public DateTime EndDate { get; set; } = new DateTime();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Assignment> Assigments { get; set; } = new List<Assignment>();

        // Constructors
        public Course(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            this.Title = title;
            this.Stream = stream;
            this.Type = type;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        // Methods
        public void Output()
        {
            Console.WriteLine("Course Name Is " +  Title);
            Console.WriteLine("Course Stream Is " + Stream);
            Console.WriteLine("Course Type Is " + Type);
            Console.WriteLine("");
        }


    }
}
