using System;
using System.Collections;

namespace Assignment_7
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate
        {
            get { return birthDate; }

            set
            {
                birthDate = DateTime.Parse(value.ToString());
            }
        }
        private DateTime birthDate;
        public string Nationality { get; set; }
    }
        
    class Student : Person
    {
        private decimal schoolFee;

        public decimal SchoolFee
        {
            get
            {
                return schoolFee;
            }

            set
            {
                schoolFee = value;
            }
        }

        public void TakeTest()
        {
            Console.WriteLine("Student {0} is taking a test", this.FirstName);
        }

        private Stack grades = new Stack();

        public Stack Grades
        {
            get { return grades; }
            set { grades = value; }
        }

    }

    class Course
    {
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public int DurationWeeks { get; set; }
        private ArrayList students = new ArrayList();

        public ArrayList Students
        {
            get { return students; }
            set { students = value; }
        }

        public void ListStudents()
        {
            foreach (Student myCourseStudent in this.Students)
            {
                Console.WriteLine("Student {0}'s last name is {1}", myCourseStudent.FirstName, myCourseStudent.LastName);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Create 3 student objects
            var endi = new Student() {FirstName = "Endilie", LastName = "Yacop"};
            var eric = new Student() {FirstName = "Eric", LastName = "Darian"};
            var abong = new Student() {FirstName = "Ronald", LastName = "Giarto"};

            //Create course object
            var myCourse = new Course() { CourseName = "Programming with C#" };

            //Add 5 grades to Student objects to each student object
            for (int i = 0; i < 5; i++)
            {
                endi.Grades.Push(10);
                eric.Grades.Push(9);
                abong.Grades.Push(8);
            }

            //Add 3 student object to course through ArrayList
            myCourse.Students.Add(endi);
            myCourse.Students.Add(eric);
            myCourse.Students.Add(abong);

            myCourse.ListStudents();

            // Just to test peeking whether the stack works or not
            foreach ( Student test in myCourse.Students)
            {
                Console.WriteLine(test.Grades.Peek());
                Console.WriteLine(test.Grades.Pop());
                Console.WriteLine(test.Grades.Peek());

            }
        }
    }
}
