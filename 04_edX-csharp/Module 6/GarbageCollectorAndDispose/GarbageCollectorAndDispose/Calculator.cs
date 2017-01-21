﻿using System;

namespace GarbageCollectorAndDispose
{
    class Calculator : IDisposable
    {
        private bool disposed = false;
        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }

        public int Divide(int first, int second)
        {
            return first/second;
        }

        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            this.Dispose();
        }

        public void Dispose()
        {
            if (!this.disposed)
            {
                Console.WriteLine("Calculator being disposed");
            }

            this.disposed = true;
            GC.SuppressFinalize(this);
        }


    }
}