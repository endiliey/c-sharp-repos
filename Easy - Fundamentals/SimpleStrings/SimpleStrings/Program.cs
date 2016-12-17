using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Endi";
            var lastName = "lie";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(fullName);
            Console.WriteLine(myFullName);

            var names = new string[3] { "John", "Jack" , "Mary"};
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);


        }
    }
}
