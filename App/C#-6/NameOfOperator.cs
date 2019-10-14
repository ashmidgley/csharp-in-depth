using System;

namespace App
{
    /* 
        Refactoring-friendly and typo-safe access to names. If we had explicitly written the string in these cases then changed the name of the method or class,
        we would have a bug. If we refactored either while using nameof, we would get a compile time error.
    */
    public static class NameOfOperator
    {
        public static void Usage()
        {
            Console.WriteLine(nameof(Usage));
            Console.WriteLine(nameof(NameOfOperator));

            NameOfOperator.CheckNotNull(0, nameof(Usage));
            NameOfOperator.CheckNotNull(-1, nameof(Usage));
        }

        public static void CheckNotNull(int argument, string method)
        {
            if(argument < 0) {
                throw new ArgumentOutOfRangeException($"Argument out of range in method: {method}.");
            }
        }

        // Always returns T no matter what type is used.
        public static void GenericUsage<T>() 
        {
            Console.WriteLine(nameof(T));
        }
    }
}
