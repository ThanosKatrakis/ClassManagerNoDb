using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Assignment
    {
        // Fields & Properties
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; } = new DateTime();
        public int OralMark { get; set; }
        public int TotalMark { get; set; }
        public Course Courses { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        // Constructors
        public Assignment(string title, string description, DateTime subDateTime, int oralMark, int totalMark)
        {
            this.Title = title;
            this.Description = description;
            this.SubDateTime = subDateTime;
            this.OralMark = oralMark;
            this.TotalMark = totalMark;
        }

        // Methods
        public void Output()
        {
            Console.WriteLine("Assignments name is " + Title);
            Console.WriteLine("Assignments Description is " + Description);
            Console.WriteLine("Last Day Of Submission is " + SubDateTime);
            Console.WriteLine("Oral mark is " + OralMark + "% of total mark.");
            Console.WriteLine("Total mark is equal to " + TotalMark);
            Console.WriteLine("");
        }
    }
}
