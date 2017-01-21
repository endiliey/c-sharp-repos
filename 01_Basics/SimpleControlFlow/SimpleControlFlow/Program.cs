using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn: 
                case Season.Summer:
                    
                    Console.WriteLine("It's perfect to go to beach");
                    break;

                default:
                    Console.WriteLine("It's not recognized season");
                    break;
            }
        }
    }
}
