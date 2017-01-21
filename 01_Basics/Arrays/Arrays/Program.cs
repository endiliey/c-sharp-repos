using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {3, 7, 9, 2, 14, 8};
            
            //Length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine(("Index of 9: " + index));

            //Clear()
            Console.WriteLine("Effect of clearing first two: ");
            Array.Clear(numbers, 0, 2);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Copy()
            Console.WriteLine("Effect of copy: ");
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            // Sort()
            Console.WriteLine("Effect of sort: ");
            Array.Sort(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Reverse()
            Console.WriteLine("Reverse");
            Array.Reverse(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

        }
    }
}
