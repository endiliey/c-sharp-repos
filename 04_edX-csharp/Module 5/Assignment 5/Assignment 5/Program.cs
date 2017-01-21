using System;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var endi = new Student("Endilie", "Yacop");
            var eric = new Student("Eric", "Darian");
            var abong = new Student("Ronald", "Giarto");
            var myCourse = new Course() {CourseName = "Programming with C#"};
            myCourse.Students[0] = endi;
            myCourse.Students[1] = eric;
            myCourse.Students[2] = abong;
            var Randy = new Teacher() {FirstName = "Randy"};
            myCourse.Teachers[0] = Randy;

            var Bachelor = new Degree() {DegreeName = "Bachelor of Science"};
            Bachelor.Course1 = myCourse;

            var InformationTechnology = new UProgram() {ProgramName = "Information Technology"};
            InformationTechnology.Degrees = Bachelor;

            Console.WriteLine("The {0} program contains the {1} degree", InformationTechnology.ProgramName, InformationTechnology.Degrees.DegreeName);
            Console.WriteLine("");
            Console.WriteLine("The {0} degree contains the course {1}", Bachelor.DegreeName, Bachelor.Course1.CourseName);
            Console.WriteLine("");
            Console.WriteLine("The {0} course contains {1} student<s>", myCourse.CourseName, Student.NumberOfStudents);
            
        }
    }
}
