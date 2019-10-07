using System;

namespace App
{
    public static class DefaultOperator
    {
        public static void PrintDefault<T>()
        {
            Console.WriteLine($"default(T) = {default(T)}");
        }
    }
}
