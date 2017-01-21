using System;

namespace Assignment_4
{
    public struct Student
    {
        public string firstName;
        public string lastName;
        public DateTime birthDate;
        public string address1;
        public string address2;
        public string city;
        public string stateProvince;
        public int postalCode;
        public string country;
    }

    public struct Teacher
    {
        public string firstName;
        public string lastName;
        public DateTime birthDate;
        public string address1;
        public string address2;
        public string city;
        public string stateProvince;
        public int postalCode;
        public string country;
    }

    public struct UProgram
    {
        public string name;
        public string departmentHead;
        public string degrees;
    }

    public struct Course
    {
        public string name;
        public int credits;
        public int weekDurations;
        public string teacher;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student endi = new Student();
            Student marshall = new Student();
            Student abong = new Student();
            Student eric = new Student();
            Student nicholas = new Student();

            //Create an array to hold 5 student structs.
            Student[] studentArray = new Student[] { endi, marshall, abong, eric, nicholas };

            //Assign values to the fields in at least one of the student structs in the array
            endi.firstName = "Endilie";
            endi.lastName = "Yacop Sucipto";
            endi.birthDate = DateTime.Parse("27/05/1996");
            endi.address1 = "Pioneer Hall";
            endi.address2 = "158 Nanyang Crescent";
            endi.city = "Singapore";
            endi.stateProvince = "Singapore";
            endi.postalCode = 637031;
            endi.country = "Singapore";

            Console.WriteLine(endi.firstName);
            Console.WriteLine(endi.lastName);
            Console.WriteLine(endi.birthDate.ToString("D"));
            Console.WriteLine(endi.address1);
            Console.WriteLine(endi.address2);
            Console.WriteLine(endi.city);
            Console.WriteLine(endi.stateProvince);
            Console.WriteLine(endi.postalCode);
            Console.WriteLine(endi.country);
        }
    }
}