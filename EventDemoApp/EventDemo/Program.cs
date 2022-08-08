using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Events allow us to signal that state has changed
// In the class that is going to fire off the events it has to have an EventHandler
// if you want to send information back you have to specify the type
// In the class, whenever you want to fire off the event you need "{EventName}?.Invoke(this, {type})"
// += because we can have multiple listeners

namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollegeClassModel history = new CollegeClassModel("History 101", 3);
            CollegeClassModel math = new CollegeClassModel("Calculus 201", 2);

            history.EnrollmentFull += CollegeClass_EnrollmentFull;

            history.SignUpStudent("Tim Corey").PrintToConsole();
            history.SignUpStudent("Kasey Hogeboom").PrintToConsole();
            history.SignUpStudent("Brian Fontana").PrintToConsole();
            history.SignUpStudent("John Smith").PrintToConsole();
            history.SignUpStudent("Ken Small").PrintToConsole();
            Console.WriteLine();

            math.EnrollmentFull += CollegeClass_EnrollmentFull;

            math.SignUpStudent("Kasey Hogeboom").PrintToConsole();
            math.SignUpStudent("Brian Fontana").PrintToConsole();
            math.SignUpStudent("John Smith").PrintToConsole();

            Console.ReadLine();
        }

        private static void CollegeClass_EnrollmentFull(object sender, string e)
        {
            CollegeClassModel model = (CollegeClassModel)sender;

            Console.WriteLine();
            Console.WriteLine($"{model.CourseTitle}: Full");
            Console.WriteLine();
        }
    }

    public static class ConsoleHelpers
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }

    public class CollegeClassModel
    {
        // create a new event handler
        public event EventHandler<string> EnrollmentFull;

        private List<string> enrolledStudents = new List<string>();
        private List<string> waitingList = new List<string>();

        public string CourseTitle { get; private set; }
        public int MaxStudents { get; private set; }

        public CollegeClassModel(string title, int maxStudents)
        {
            CourseTitle = title;
            MaxStudents = maxStudents;
        }

        public string SignUpStudent(string studentName)
        {
            string output = "";
            if (enrolledStudents.Count < MaxStudents)
            {
                enrolledStudents.Add(studentName);
                output = $"{studentName} was enrolled in {CourseTitle}";
                if (enrolledStudents.Count == MaxStudents)
                    EnrollmentFull?.Invoke(this, $"{CourseTitle} enrollment is now full");
            }
            else
            {
                waitingList.Add(studentName);
                output = $"{studentName} was added to the waitlist for {CourseTitle}";
            }

            return output;
        }
    }
}

// PRO TIP: Use events to let others know about state changes or other significant events.
// HOMEWORK: Create an event in a class and then consume that class. Attach a listener to the event and have it write to the console.