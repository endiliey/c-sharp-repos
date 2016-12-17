using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            
            myCar.Make = "Oldmobile";
            myCar.Model = "Cutlas supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", 
                myOtherCar.Make, 
                myOtherCar.Model, 
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}",
               myCar.Make,
               myCar.Model,
               myCar.Year,
               myCar.Color);

            myOtherCar = null;
            myCar = null;

            Car myThirdCar = new Car("Nissan", "Test", 1989, "Red");
            Console.WriteLine("{0} {1} {2} {3}",
               myThirdCar.Make,
               myThirdCar.Model,
               myThirdCar.Year,
               myThirdCar.Color);

            Car.MyMethod();
            Console.ReadLine();
        }
           
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //Constructor
        public Car()
        {
            //this.Make = "Nissan";
            //There is no need to use this. (but usually yes for C++/other)
            //You could load from a configuration file, a database,etc
            Make = "Nissan";

        }

        //Overloaded Constructor
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        //static means that we don't need to create an instance of it
        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
            //we cannot write Console.WriteLine(Make); because it is static. Doesn't have any instance)
            //static method is more of utility
        }
    }
}
