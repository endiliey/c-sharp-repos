using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblemsExercise
{
    public class ArrayProblems
    {
        public static void Exercise1()
        {
            var names = new List<string>();
            while (true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;

                names.Add(input);

            }

            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();

        }
        public static void Exercise2()
        {
            Console.WriteLine("Whats your real name: ");
            var realName = Console.ReadLine();
            var arrayName = new char[realName.Length];

            for (var i = 0; i <= realName.Length - 1; i++)
                arrayName[i] = realName[realName.Length - 1 - i];

            var reversed = new string(arrayName);
            Console.WriteLine("The reversed name is: " + reversed);

        }
        public static void Exercise3()
        {
            Console.WriteLine("Please enter a number: ");
            var numbers = new List<int>();
            var count = 0;
            while (true)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(input))
                {
                    Console.WriteLine("Error, please re-enter: ");
                    continue;
                }

                numbers.Add(input);
                if (count == 5)
                    break;

                count++;

            }

            numbers.Sort();
            Console.WriteLine("The sorted order are: ");
            foreach (var str in numbers)
            {
                Console.WriteLine(str);
            }
        }
        public static void Exercise4()
        {
            Console.WriteLine("Please enter a number or write \"Quit\" to exit");
            var numbers = new List<int>();
            var unique = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Quit")
                    break;

                if (!numbers.Contains(Convert.ToInt32(input)))
                    unique.Add(Convert.ToInt32(input));
                numbers.Add(Convert.ToInt32(input));
            }

            Console.WriteLine("Here are all the unique numbers: ");
            foreach (var uniquenumber in unique)
            {
                Console.WriteLine(uniquenumber);
            }
        }
        public static void Exercise5()
        {
            string[] elements;
            while (true)
            {
                Console.WriteLine("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayProblems.Exercise1();
            ArrayProblems.Exercise2();
            ArrayProblems.Exercise3();
            ArrayProblems.Exercise4();
            ArrayProblems.Exercise5();
        }
    }
}
