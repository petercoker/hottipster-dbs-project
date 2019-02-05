using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQExamples
{
    public partial class AdvancedExamplesFrm : Form
    {
        int SortField = 0;
        readonly int FieldCount = 4;

        private Student John = new Student
        {
            ProgrammeID = 1,
            ID = 100,
            FirstName = "John",
            Surname = "Lennon",
            Grades = new List<int> { 45, 54, 71, 77 }
        };

        private Student Paul = new Student
        {
            ProgrammeID = 1,
            ID = 55,
            FirstName = "Paul",
            Surname = "McCartney",
            Grades = new List<int> { 35, 65, 43, 49}
        };

        private Student Ringo = new Student
        {
            ProgrammeID = 4,
            ID = 102,
            FirstName = "Ringo",
            Surname = "Starr",
            Grades = new List<int> { 71, 43, 51, 49 }
        };

        private Student George = new Student
        {
            ProgrammeID = 2,
            ID = 75,
            FirstName = "George",
            Surname = "Harrison",
            Grades = new List<int> { 11, 67, 51, 73 }
        };

        private Student Genghis = new Student
        {
            ProgrammeID = 5,
            ID = 104,
            FirstName = "Genghis",
            Surname = "Khan",
            Grades = new List<int> { 100, 100, 100, 100 }
        };

        private Student William = new Student
        {
            ProgrammeID = 3,
            ID = 105,
            FirstName = "William",
            Surname = "Shakespeare",
            Grades = new List<int> { 98, 64, 53, 74 }
        };

        private Student Doctor = new Student
        {
            ProgrammeID = 4,
            ID = 1,
            FirstName = "Doctor",
            Surname = "Who",
            Grades = new List<int> { 101, 101, 101, 101 }
        };

        private Student Sherlock = new Student
        {
            ProgrammeID = 8,
            ID = 2,
            FirstName = "Shelock",
            Surname = "Holmes",
            Grades = new List<int> { 101, 101, 101, 101 }
        };

        private Student JohnH = new Student
        {
            ProgrammeID = 7,
            ID = 3,
            FirstName = "John",
            Surname = "Watson",
            Grades = new List<int> { 70, 70, 70, 90 }
        };

        private List<Course> ProgrammeCourses = new List<Course>();

        private List<Student> Students = null;
        public AdvancedExamplesFrm()
        {
            Students = new List<Student> { John, Paul, Ringo, George };

            ProgrammeCourses.Add(new Course("Maths", 1));
            ProgrammeCourses.Add(new Course("English", 1));
            ProgrammeCourses.Add(new Course("History", 1));
            ProgrammeCourses.Add(new Course("Classics", 2));
            ProgrammeCourses.Add(new Course("French", 3));
            ProgrammeCourses.Add(new Course("Geography", 3));
            ProgrammeCourses.Add(new Course("Quantum Mechanics", 4));
            ProgrammeCourses.Add(new Course("Tardis Maintenance", 4));
            ProgrammeCourses.Add(new Course("Dalek Disassembly", 4));
            ProgrammeCourses.Add(new Course("Wormhole Theories", 4));
            ProgrammeCourses.Add(new Course("Murder", 5));
            ProgrammeCourses.Add(new Course("Conquest", 5));
            ProgrammeCourses.Add(new Course("Pillaging", 5));
            ProgrammeCourses.Add(new Course("The Fine Art of War", 5));

            InitializeComponent();
        }

        private void ModifyStudentList(bool addStudents)
        {
            if (addStudents)
            {
                Students.Add(Genghis);
                Students.Add(William);
                Students.Add(Doctor);
                Students.Add(Sherlock);
                Students.Add(JohnH);
            }
            else
            {
                Students.Remove(Genghis);
                Students.Remove(William);
                Students.Remove(Doctor);
                Students.Remove(Sherlock);
                Students.Remove(JohnH);
            }
        }

        private void ResetRTBs()
        {
            rtbStudents.Clear();
            rtbExtraQueries.Clear();
            rtbNumbers.Clear();
        }

        private void AdvancedExamplesFrm_Load(object sender, EventArgs e)
        {
            foreach (var student in Students)
            {
                rtbStudents.AppendText(student.ToString());
            }
        }

        private void btnShowType_Click(object sender, EventArgs e)
        {
            ResetRTBs();
            /*
             * We use .NET reflection here--we won't be covering reflection in AdvProg, but it
             * essentially provides utilies/functions that allow you to determine the 
             * properties/attributes/methods of objects and assemblies at runtime. It is a powerful
             * technique, but care is required when using it, particularly if it is being used to
             * dynamically create an instance of an object based on metadata collected from 
             * assemblies and/or runtime objects, or if you are invoking code on objects dynamically
             * (which means you have no compile time safety through the type system). ORMs (object
             * relational mappers), testing frameworks, plugins, etc all use .NET reflection.
             * Note: there is obviously a peformance impact when using .NET reflection.
             */
            IEnumerable<Student> sortedByFirstNameIE = from student in Students
                                                       orderby student.FirstName
                                                       select student;

            rtbStudents.AppendText($"Students by Firstname:{Environment.NewLine}");

            foreach (var student in sortedByFirstNameIE)
            {
                rtbStudents.AppendText($"CourseID: {student.ProgrammeID.ToString()}{Environment.NewLine}" +
                                         $"Firstname: {student.FirstName}{Environment.NewLine}" +
                                         $"Surname: {student.Surname}{Environment.NewLine}");
            }

            // Now use reflection...
            string msg1 = String.Format($"{nameof(sortedByFirstNameIE)} is actually of type {sortedByFirstNameIE.GetType().Name} which" +
                                        $" is defined in assembly {sortedByFirstNameIE.GetType().Assembly.GetName().Name}");

            rtbExtraQueries.AppendText(msg1 + Environment.NewLine);

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            IEnumerable<int> oddNums = from i in nums
                                       where i % 2 != 0
                                       select i;

            foreach (var i in oddNums)
            {
                rtbNumbers.AppendText($"{i}{Environment.NewLine}");
            }
            // Now use reflection again...
            string msg2 = String.Format($"{nameof(oddNums)} is actually of type {oddNums.GetType().Name} which" +
                                        $" is defined in assembly {oddNums.GetType().Assembly.GetName().Name}");

            rtbExtraQueries.AppendText(msg2 + Environment.NewLine);
        }
    }
}
