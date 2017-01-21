#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        private int x;
        private int y;
        private static int objectCount = 0;
        public Point()
        {
            Console.WriteLine("Default Constructor Called");
            objectCount++;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            objectCount++;
        }

        public void PrintCoords()
        {
            Console.WriteLine("X:{0} and Y:{1}", this.x, this.y);
        }

        public static int ObjectCount()
        {
            return objectCount;
        }
    }
}
