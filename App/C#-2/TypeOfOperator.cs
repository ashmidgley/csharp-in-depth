using System;

namespace App
{
    public static class TypeOfOperator
    {
        public static void PrintType<T>()
        {
            Console.WriteLine($"typeof(T) = {typeof(T)}");
        }
    }
}
