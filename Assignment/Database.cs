using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Database
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ALL LISTS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public List<Student> students { get; set; } = new List<Student>();
        public List<Trainer> trainers { get; set; } = new List<Trainer>();
        public List<Assignment> assignments { get; set; } = new List<Assignment>();
        public List<Course> courses { get; set; } = new List<Course>();
        public List<StudentsPerCourse> studentsPerCourses { get; set; } = new List<StudentsPerCourse>();
        public List<TrainersPerCourse> trainersPerCourse { get; set; } = new List<TrainersPerCourse>();
        public List<AssignmentsPerCourse> assignmentPerCourse { get; set; } = new List<AssignmentsPerCourse>();

        public Database()
        {
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ STUDENTS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Student s1 = new Student("Thanos", "Katrakis", new DateTime(1990, 12, 22), 3500);
            Student s2 = new Student("Sakis", "Panou", new DateTime(1989, 11, 24), 3500);
            Student s3 = new Student("Dora", "Ioannou", new DateTime(1970, 12, 26), 3500);
            Student s4 = new Student("Anna", "Plaka", new DateTime(1971, 11, 20), 3500);
            Student s5 = new Student("Maria", "Karakitou", new DateTime(1989, 10, 9), 3500);
            Student s6 = new Student("Konstantina", "Parisi", new DateTime(1988, 5, 4), 3500);
            Student s7 = new Student("Niki", "Oikonomou", new DateTime(1985, 11, 4), 3500);
            Student s8 = new Student("Fotis", "Hatzidakis", new DateTime(1999, 6, 6), 3500);
            Student s9 = new Student("Laoura", "Koureta", new DateTime(2000, 9, 14), 3500);
            Student s10 = new Student("Antreas", "Papadopoulos", new DateTime(1978, 3, 4), 3500);
            Student s11 = new Student("Akis", "Arseniou", new DateTime(2001, 8, 30), 3500);
            Student s12 = new Student("Thanasis", "Karagiannis", new DateTime(1991, 7, 6), 3500);
            Student s13 = new Student("Elsa", "Nikou", new DateTime(2005, 1, 1), 3500);
            Student s14 = new Student("Daniela", "Karvela", new DateTime(1980, 2, 24), 3500);
            Student s15 = new Student("Elena", "Fotiou", new DateTime(1985, 7, 1), 3500);

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);
            students.Add(s6);
            students.Add(s7);
            students.Add(s8);
            students.Add(s9);
            students.Add(s10);
            students.Add(s11);
            students.Add(s12);
            students.Add(s13);
            students.Add(s14);
            students.Add(s15);



            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ TRAINERS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Trainer t1 = new Trainer("Konstantinos", "Zitis", "Coding Instructor");
            Trainer t2 = new Trainer("Panagiotis", "Mpozas", "Coding Instructor");
            Trainer t3 = new Trainer("Ektoras", "Gatsos", "Coding Instructor");
            Trainer t4 = new Trainer("Zacharias", "Alertas", "Coding Instructor");

            trainers.Add(t1);
            trainers.Add(t2);
            trainers.Add(t3);
            trainers.Add(t4);

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ASSIGNMENT ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Assignment a1 = new Assignment("Individual Project Part A", "Design A Basic App Of Your Choise", new DateTime(2020, 2, 1), 30, 100);
            Assignment a2 = new Assignment("Individual Project Part B", "Design Database For your App", new DateTime(2020, 4, 1), 20, 100);
            Assignment a3 = new Assignment("Individual Project Part C", "Design UX/UI For Your App", new DateTime(2020, 8, 1), 40, 100);
            Assignment a4 = new Assignment("Individual Project Part D", "Implement Your App For Different Operating Systems", new DateTime(2020, 9, 15), 10, 100);

            assignments.Add(a1);
            assignments.Add(a2);
            assignments.Add(a3);
            assignments.Add(a4);

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ COURSES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Course c1 = new Course("Programming with Python", "Machine Learning", "Morning Classes", new DateTime(2020, 1, 1), new DateTime(2020, 10, 1));
            Course c2 = new Course("Programming with Javascript", "Create Websites", "Evening Classes", new DateTime(2020, 1, 1), new DateTime(2020, 10, 1));
            Course c3 = new Course("Programming with Swift", "Create OS apps", "Morning Classes", new DateTime(2020, 1, 1), new DateTime(2020, 10, 1));
            Course c4 = new Course("Programming with C", "Create Operating Systems", "Evening Classes", new DateTime(2020, 1, 1), new DateTime(2020, 10, 1));

            courses.Add(c1);
            courses.Add(c2);
            courses.Add(c3);
            courses.Add(c4);

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ STUDENTS PER COURSE ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            List<Student> lspc1 = new List<Student>() { s1, s2, s3, s14, s15 };
            StudentsPerCourse spc1 = new StudentsPerCourse(c1, lspc1);

            List<Student> lspc2 = new List<Student>() { s4, s6, s7, s1, s10 };
            StudentsPerCourse spc2 = new StudentsPerCourse(c2, lspc2);

            List<Student> lspc3 = new List<Student>() { s8, s9, s10, s11, s4 };
            StudentsPerCourse spc3 = new StudentsPerCourse(c3, lspc3);

            List<Student> lspc4 = new List<Student>() { s12, s13, s14, s15, s9 };
            StudentsPerCourse spc4 = new StudentsPerCourse(c4, lspc4);

            studentsPerCourses.Add(spc1);
            studentsPerCourses.Add(spc2);
            studentsPerCourses.Add(spc3);
            studentsPerCourses.Add(spc4);

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ TRAINERS PER COURSE ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            List<Trainer> ltpc1 = new List<Trainer>() { t1, t2 };
            TrainersPerCourse tpc1 = new TrainersPerCourse(c1, ltpc1);

            List<Trainer> ltpc2 = new List<Trainer>() { t3, t2 };
            TrainersPerCourse tpc2 = new TrainersPerCourse(c2, ltpc2);

            List<Trainer> ltpc3 = new List<Trainer>() { t4, t3 };
            TrainersPerCourse tpc3 = new TrainersPerCourse(c3, ltpc3);

            List<Trainer> ltpc4 = new List<Trainer>() { t2, t3 };
            TrainersPerCourse tpc4 = new TrainersPerCourse(c4, ltpc4);

            trainersPerCourse.Add(tpc1);
            trainersPerCourse.Add(tpc2);
            trainersPerCourse.Add(tpc3);
            trainersPerCourse.Add(tpc4);

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ASSIGNMENTS PER COURSE ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            List<Assignment> lapc1 = new List<Assignment>() { a1, a2, a3, a4 };
            AssignmentsPerCourse apc1 = new AssignmentsPerCourse(c1, lapc1);

            List<Assignment> lapc2 = new List<Assignment>() { a1, a2, a3, a4 };
            AssignmentsPerCourse apc2 = new AssignmentsPerCourse(c2, lapc2);

            List<Assignment> lapc3 = new List<Assignment>() { a1, a2, a3, a4 };
            AssignmentsPerCourse apc3 = new AssignmentsPerCourse(c3, lapc3);

            List<Assignment> lapc4 = new List<Assignment>() { a1, a2, a3, a4 };
            AssignmentsPerCourse apc4 = new AssignmentsPerCourse(c4, lapc4);

            assignmentPerCourse.Add(apc1);
            assignmentPerCourse.Add(apc2);
            assignmentPerCourse.Add(apc3);
            assignmentPerCourse.Add(apc4);

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ CHOOSE SYNTHETIC OR NO ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Console.WriteLine("\aHello stranger.. What's your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("So " + userName + ". Whould you like to insert the data by yourself (Y/N)?");
            string yesOrNo = Console.ReadLine();

            while ((yesOrNo.ToLower() != "y") && (yesOrNo.ToLower() != "n"))
            {
                Console.WriteLine("Plz give me Y or N..");
                yesOrNo = Console.ReadLine();
            }

            if (yesOrNo.ToLower() == "y")
            {

                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ STUDENT INPUT ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                string studentYesNo = "";
                do
                {
                    Console.WriteLine("Please give student name:");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Please give studen last name:");
                    string lastName = Console.ReadLine();

                    Console.WriteLine("Please give student birthdate in form YYYY/MM/DD exp. 1990/07/09. :");
                    DateTime birthDate = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Please give student tuition fees:");
                    int tuitionFees = int.Parse(Console.ReadLine());

                    Student student = new Student(firstName, lastName, birthDate, tuitionFees);
                    students.Add(student);

                    Console.WriteLine("Do you want to add another student Y/N ?");
                    studentYesNo = Console.ReadLine();

                } while (studentYesNo.ToLower() == "y");

                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ TRAINER INPUT ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                string trainerYesNo = "";
                do
                {
                    Console.WriteLine("Please give trainer name:");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Please give trainer last name:");
                    string lastName = Console.ReadLine();

                    Console.WriteLine("Please give trainer subject:");
                    string subject = Console.ReadLine();

                    Trainer trainer = new Trainer(firstName, lastName, subject);
                    trainers.Add(trainer);

                    Console.WriteLine("Do you want to add another trainer Y/N ?");
                    trainerYesNo = Console.ReadLine();

                } while (trainerYesNo.ToLower() == "y");

                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ COURSE INPUT ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                string coureYesNo = "";
                do
                {
                    Console.WriteLine("Please give course title:");
                    string title = Console.ReadLine();

                    Console.WriteLine("Please give course stream:");
                    string stream = Console.ReadLine();

                    Console.WriteLine("Please give course type:");
                    string type = Console.ReadLine();

                    Console.WriteLine("Please give course start date in form YYYY/MM/DD exp. 1990/07/09. :");
                    DateTime startDate = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Please give end date in form YYYY/MM/DD exp. 1990/07/09. :");
                    DateTime endDate = Convert.ToDateTime(Console.ReadLine());

                    Course course = new Course(title, stream, type, startDate, endDate);
                    courses.Add(course);

                    Console.WriteLine("Do you want to add another course Y/N ?");
                    coureYesNo = Console.ReadLine();

                } while (coureYesNo.ToLower() == "y");

                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ASSIGNMENT INPUT ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                string assignmentYesNo = "";
                do
                {
                    Console.WriteLine("Please give assigment title:");
                    string title = Console.ReadLine();

                    Console.WriteLine("Please give assigment description:");
                    string description = Console.ReadLine();

                    Console.WriteLine("Please give date in form YYYY/MM/DD exp. 1990/07/09. :");
                    DateTime subDate = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Please give oral mark between 0 to 100:");
                    int oralMark = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please give total mark scale:");
                    int totalMark = int.Parse(Console.ReadLine());

                    Assignment assignment = new Assignment(title, description, subDate, oralMark, totalMark);
                    assignments.Add(assignment);

                    Console.WriteLine("Do you want to add another assignment Y/N ?");
                    assignmentYesNo = Console.ReadLine();

                } while (assignmentYesNo.ToLower() == "y");

            }
            else if (yesOrNo.ToLower() == "n")
            {
                Console.WriteLine("Your default entities are:");
            }
        }

    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ALL PRINTS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    public void PrintAllStudents()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t~~~ Students Info ~~~");
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (var item in students)
            {
                item.Output();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void PrintAllTrainers()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t~~~ Trainers Info ~~~");
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (var item in trainers)
            {
                item.Output();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void PrintAllAssignment()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t~~~ Assignments Info ~~~");
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (var item in assignments)
            {
                item.Output();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void PrintAllCourses()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t~~~ Courses Info ~~~");
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (var item in courses)
            {
                item.Output();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void PrintStudentsPerCourse()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t~~~ Students Per Course ~~~");
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (var item in studentsPerCourses)
            {
                item.Output();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void PrintTrainersPerCourse()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t~~~ Trainers Per Course ~~~");
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (var item in trainersPerCourse)
            {
                item.Output();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void PrintAllAssignmentsPerCourse()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t~~~ Assignments Per Course ~~~");
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (var item in assignmentPerCourse)
            {
                item.Output();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ STUDENTS WITH MORE THAN ONE COURSE ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public void printStudentsWithMoreThanOne()
        {
            List<Student> studentOneOreMoreCourse = new List<Student>();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t~~~ Students With More Than One Courses ~~~");
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (var item in students)
            {
                if (item.Courses.Count() > 1)
                {
                    studentOneOreMoreCourse.Add(item);
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}