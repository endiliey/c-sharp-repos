using System;


namespace ExercisesSoln1
{
    public class Conditionals
    {
        public static void Exercise1()
        {
            int number;
            Console.WriteLine("Please enter a number between 1 to 10");
            number = Int32.Parse(Console.ReadLine());
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("Please enter first integer numbers");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second integer numbers");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The maximum number between these two are");

            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else
            {
                Console.WriteLine(number2);
            }
        }

        public static void Exercise3()
        {
            Console.WriteLine("Please enter height");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter width");
            var width = Convert.ToInt32(Console.ReadLine());
            var orientation = width > height ? ImageOrientation.LandScape : ImageOrientation.Portrait;
            Console.WriteLine("Your Image Orientation is: " + orientation);
        }

        public enum ImageOrientation
        {
            LandScape = 0,
            Portrait = 1
        }

        public static void Exercise4()
        {
            Console.WriteLine("Please enter a speed limit in km/h");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter car speed in km/h");
            var carSpeed = Convert.ToInt32(Console.ReadLine());
            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                const int demeritPointsPerKm = 5;
                var demeritPoints = (carSpeed - speedLimit)/ demeritPointsPerKm;
                Console.WriteLine("Demerit Points: " + demeritPoints);
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
            }

        }

    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Conditionals.Exercise1();

            Conditionals.Exercise2();

            Conditionals.Exercise3();

            Conditionals.Exercise4();
        }
    }
}
