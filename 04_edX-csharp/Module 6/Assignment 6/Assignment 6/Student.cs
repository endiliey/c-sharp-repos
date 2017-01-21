using System;

namespace Assignment_6
{
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
    }
}