using System;

namespace Assignment_6
{
    class Teacher : Person
    {
        private decimal salary;

        public decimal Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public void GradeTest()
        {
            Console.WriteLine("Teacher {0} is grading a test", this.FirstName);
        }
    }
}