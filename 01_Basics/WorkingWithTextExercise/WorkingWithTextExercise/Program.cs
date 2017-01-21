using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithTextExercise
{
    public class Exercise1
    {
        public static void Soln1()
        {
            // Write a program and ask user to enter a few numbers separated by a hyphen.
            // If numbers are consecutive. For Example, if input is "5-6-7-8-9", display "Consecutive"
            // If numbers arent consecutive. For example, if input is "5-2-3-4", display "Not Consecutive"
            Console.WriteLine("Please enter few numbers separated by a hyphen: ");
            var input = Console.ReadLine();
            var number = input.Split('-');
            for (var i = 0; i < number.Length - 1; i++)
            {
                if (Convert.ToInt32(number[i + 1]) - Convert.ToInt32(number[i]) != 1)
                {
                    Console.WriteLine("Not Consecutive");
                    break;
                }
                if (i == number.Length - 2)
                    Console.WriteLine("Consecutive");
            }
        }

        public static void Soln2()
        {
            // Write a program and ask the user to enter a few numbers separated by a hyphen. 
            // If user simply presses Enter, without supplying an input, exit immediately
            // Otherwise, check if there are duplicates. If so, display "Duplicate" on the consolle.
            Console.WriteLine("Please enter few numbers separated by a hyphen: ");
            var secondInput = Console.ReadLine();
            var numberList = new List<int>();
            if ( !String.IsNullOrWhiteSpace(secondInput))
            {
                foreach (var test in secondInput.Split('-'))
                {
                    if (numberList.Contains(Convert.ToInt32(test)))
                    {
                        Console.WriteLine("Duplicate");
                        break;
                    }
                    numberList.Add(Convert.ToInt32(test));
                }
            }
        }

        public static void Soln3()
        {
            // Write a program and ask the user to enter a time value in the 24-hour time format (e.g 19:00).
            // A valid time should be between 00:00 and 23:59.
            // If the time is valid, display "OK", otherwise display "Invalid Time"
            // If the user doesn't provide any values, consider it as invalid time
            Console.WriteLine("Please enter a time value in the 24-hour tie format (e.g 19:00) ");
            var dateTimeInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(dateTimeInput))
            {
                var components = dateTimeInput.Split(':');
                if (components.Length != 2)
                {
                    Console.WriteLine("Invalid Time");
                }
                else
                {
                    try
                    {
                        var hour = Convert.ToInt32(components[0]);
                        var minute = Convert.ToInt32(components[1]);

                        if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                            Console.WriteLine("Ok");
                        else
                            Console.WriteLine("Invalid Time");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Time");
                    }
                }

            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public static void Soln4()
        {
            // Write a program and ask the user to enter few words separated by a space. Use the words to create a
            // variable name with PascalCase. For example: if user types "number of students", display "NumberOfStudents".
            // Make sure program is not dependent on the input. So,if the user types "NUMBER OF STUDENTS", the program
            // shoudl still display "NumberOfStudents"
            Console.WriteLine("Please enter a few words separated by a space: ");
            var fourthInput = Console.ReadLine();
            var pascalStringBuilder = new StringBuilder();
            var pascalComponent = fourthInput.ToLower().Split(' ');
            foreach (var testWord in pascalComponent)
            {
                pascalStringBuilder.Append(testWord);
                pascalStringBuilder.Replace(testWord[0], testWord.ToUpper()[0]);
            }

            Console.WriteLine(pascalStringBuilder);
            
        }

        public static void Soln5()
        {
            // Write a program and ask the user to enter an English word. Count the number of voewels (a,e,o,u,i) in the
            // word. So, if the user enters "inadequate", the program should display 6 on the console.
            Console.WriteLine("Please enter an English Word: ");
            var vowelCount = 0;
            var englishChar = Console.ReadLine().ToLower();
            var vowels = new List<char>() {'a', 'e', 'o', 'u', 'i'};
            foreach (var testChar in englishChar)
            {
                if (vowels.Contains(testChar))
                    vowelCount++;
            }

            Console.WriteLine("The number of vowels are: {0} ", vowelCount);
            


        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1.Soln1();
            Exercise1.Soln2();
            Exercise1.Soln3();
            Exercise1.Soln4();
            Exercise1.Soln5();
        }
    }
}
