using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Endilie Y ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim() );
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper() );
            Console.WriteLine("ToLower: '{0}'", fullName.Trim().ToLower() );

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LasttName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Endi", "Endilie"));

            if (String.IsNullOrEmpty("Test"))
                Console.WriteLine("Invalid");

            //Better Check
            if (String.IsNullOrWhiteSpace(""))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToString(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));


        }
    }
}
