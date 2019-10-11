using System;

namespace App
{
    public class Finalizer
    {
        public Finalizer()
        {
            Console.WriteLine("Constructor called.");
        }

        // We have no control over when a finalizer is called because it is determined by the garbage collector.
        ~Finalizer()
        {
            // Clean up statements...
        }
    }
}
