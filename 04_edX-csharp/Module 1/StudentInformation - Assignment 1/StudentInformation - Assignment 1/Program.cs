using System;

namespace StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Endilie";
            string lastName = "Yacop Sucipto";
            DateTime birthDate = new DateTime(1996, 5, 27);
            string address1 = "158 Nanyang Crescent";
            string address2 = "Blk 18C, #04-224";
            string city = "Singapore";
            string stateProvince = "Singapore";
            int postalCode = 637031;
            string country = "Singapore";

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(birthDate);
            Console.WriteLine(address1);
            Console.WriteLine(address2);
            Console.WriteLine(city);
            Console.WriteLine(stateProvince);
            Console.WriteLine(postalCode);
            Console.WriteLine(country);
        }
    }
}
