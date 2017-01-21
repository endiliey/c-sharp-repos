using System;

namespace Assignment_5
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public static int NumberOfStudents = 0;

        public Student(string first, string last)
        {
            this.FirstName = first;
            this.LastName = last;
            NumberOfStudents++;
        }

    }
}