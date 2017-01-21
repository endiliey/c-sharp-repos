using System;

namespace Assignment_6
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
}