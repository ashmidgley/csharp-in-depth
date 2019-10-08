using System;
using System.Collections.Generic;

namespace App 
{
    // Iterators execute lazily, meaning the code to get a value is executed only when you need the value.
    public static class Iterators
    {
        public static IEnumerable<int> SimpleIterator()
        {
            yield return 1000;
            for(int i = 1; i <= 10; i++)
            {
                yield return i;
            }
            yield return 2000;
        }

        public static void PrintSimpleIterator()
        {
            foreach(int value in SimpleIterator())
            {
                Console.WriteLine(value);
            }
        }

        // You could implement this by storing the values in a list but this could become problematic
        // as the value gets bigger.
        public static IEnumerable<int> Fibonacci()
        {
            int current = 0;
            int next = 1;
            while(true)
            {
                yield return current;
                int oldCurrent = current;
                current = next;
                next = oldCurrent += next;
            }
        }

        public static void PrintFibonnaciUpToValue(int candidate)
        {
            foreach(int value in Fibonacci()) {
                if(value > candidate)
                    break;
                Console.WriteLine(value);
            }
        }
    }
}
