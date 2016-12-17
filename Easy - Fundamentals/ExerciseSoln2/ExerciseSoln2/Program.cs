using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExerciseSoln2
{
    public class ControlFlow
    {
        public static void Exercise1()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i%3 == 0)
                    count++;
            }
            Console.WriteLine(count);
        }

        public static void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Please enter a number or \"ok\" to exit");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                if (input.ToLower() == "ok")
                    break;
                sum += Convert.ToInt32(input);
            }

            Console.WriteLine(sum);
        }

        public static void Exercise3()
        {
            Console.WriteLine("Please enter a number to have the factorial of it computed");
            var input = Convert.ToInt32(Console.ReadLine());
            var sum = 1;
            while (input > 0)
            {
                sum *= input;
                input--;
            }

            Console.WriteLine(sum);
        }

        public static void Exercise4()
        {
            var randomNumber = new Random().Next(1, 10);
            Console.WriteLine("Please guess a number between 1 to 10");
            var i = 1;
            while (true)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == (int) randomNumber)
                {
                    Console.WriteLine("You are correct");
                    break;
                }

                if (i == 4)
                {
                    Console.WriteLine("Your chance is no more");
                    break;
                }

                i++;

            }
        }

        public static void Exercise5()
        {
            Console.WriteLine("Please enter series of numbers separated by comma: ");
            var input = Console.ReadLine();
            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);
            foreach (var test in numbers)
            {
                var number = Convert.ToInt32(test);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("The maximum number is: " + max);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ControlFlow.Exercise1();
            ControlFlow.Exercise2();
            ControlFlow.Exercise3();
            ControlFlow.Exercise4();
            ControlFlow.Exercise5();

        }
    }
}
