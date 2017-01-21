using System;
using System.Collections;
using System.Collections.Generic;

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

        private Stack<int> grades = new Stack<int>(5);

        public Stack<int> Grades
        {
            get
            {
                return grades;
            }

            set
            {
                grades = value;
            }
        }

        public void TakeTest()
        {
            Console.WriteLine("Student {0} is taking a test", this.FirstName);
        }

    }

    class Course
    {
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public int DurationWeeks { get; set; }

        private List<Student> students = new List<Student>();

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public void ListStudents()
        {
            //Using a foreach loop, iterate over the Students in the List<T> and output their 
            //first and last names to the console window
            foreach (Student test in this.Students)
            {
                Console.WriteLine("First Name: {0} Last Name: {1}", test.FirstName, test.LastName);
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

            
        }
    }
}
