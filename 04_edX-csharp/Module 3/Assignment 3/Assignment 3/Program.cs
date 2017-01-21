using System;
using System.Globalization;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GetStudentInformation();
                GetTeacherInformation();
                GetUProgramInformation();
                GetDegreeInformation();
                GetCourseInformation();
                ValidateBirthday(DateTime.Parse("27/05/1996"));
            }
            catch (NotImplementedException niEx)
            {
                Console.WriteLine(niEx.Message);                
            }
        }
        public static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string studentFirstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string studentLastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birth year (example : 19/05/1996) : ");
            DateTime studentBirthDate = DateTime.ParseExact(Console.ReadLine(), "d/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter the student's address 1: ");
            string studentAddress1 = Console.ReadLine();
            Console.WriteLine("Enter the student's address 2: ");
            string studentAddress2 = Console.ReadLine();
            Console.WriteLine("Enter the student's city: ");
            string studentCity = Console.ReadLine();
            Console.WriteLine("Enter the student's state/province: ");
            string studentStateProvince = Console.ReadLine();
            Console.WriteLine("Enter the student's postal code number (ex: 637031): ");
            int studentPostalCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the student's country: ");
            string studentCountry = Console.ReadLine();

            PrintStudentDetails(studentFirstName, studentLastName, studentBirthDate.ToString("D"));
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string teacherFirstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            string teacherLastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birth year in dd/MM/yyyy format (example : 19/05/1996) : ");
            DateTime teacherBirthDate = DateTime.ParseExact(Console.ReadLine(), "d/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter the teacher's address 1: ");
            string teacherAddress1 = Console.ReadLine();
            Console.WriteLine("Enter the teacher's address 2: ");
            string teacherAddress2 = Console.ReadLine();
            Console.WriteLine("Enter the teacher's city: ");
            string teacherCity = Console.ReadLine();
            Console.WriteLine("Enter the teacher's state/province: ");
            string teacherStateProvince = Console.ReadLine();
            Console.WriteLine("Enter the teacher's postal code: ");
            int teacherPostalCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the teacher's country: ");
            string teacherCountry = Console.ReadLine();

            PrintTeacherDetails(teacherFirstName, teacherLastName, teacherBirthDate.ToString("D"));
        }

        static void GetUProgramInformation()
        {
            Console.WriteLine("Enter the program name: ");
            string programName = Console.ReadLine();
            Console.WriteLine("Enter the department head: ");
            string departmentHead = Console.ReadLine();
            Console.WriteLine("Enter the degrees: ");
            string degrees = Console.ReadLine();

            PrintUProgramDetails(programName, departmentHead, degrees);
        }

        static void GetDegreeInformation()
        {
            Console.WriteLine("Enter the degree name: ");
            string degreeName = Console.ReadLine();
            Console.WriteLine("Enter the credits required: ");
            int creditsRequired = Convert.ToInt32(Console.ReadLine());

            PrintDegreeDetails(degreeName, creditsRequired);
        }

        static void GetCourseInformation()
        {
            Console.WriteLine("Enter the course name: ");
            string courseName = Console.ReadLine();
            Console.WriteLine("Enter the credits (ex: 19): ");
            int credits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the duration in weeks (ex: 12): ");
            int weekDuration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the teacher name: ");
            string teacherName = Console.ReadLine();

            PrintCourseDetails(courseName, credits, weekDuration, teacherName);
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("Student {0} {1} was born on : {2}", first, last, birthday);
        }

        static void PrintTeacherDetails(string first, string last, string birthday)
        {
            Console.WriteLine("Teacher {0} {1} was born on : {2}", first, last, birthday);
        }

        static void PrintUProgramDetails(string program, string head, string degrees)
        {
            Console.WriteLine("{0}'s department head is {1} and the degrees is {2}", program, head, degrees);
        }

        static void PrintDegreeDetails(string degree, int credit)
        {
            Console.WriteLine("The \"{0}\" degree requires {1} credits", degree, credit );
        }

        static void PrintCourseDetails(string course, int credits, int weekDuration, string teacher)
        {
            Console.WriteLine("{0} course requires {1} credits, lasts {2} weeks and taught by {3}", 
                               course, credits, weekDuration, teacher );
        }

        static void ValidateBirthday(DateTime birthdayTest)
        {
            throw new NotImplementedException();
        }
    }
}
