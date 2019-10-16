using System;
using System.Collections.Generic;

namespace App 
{
    public static class Iterators
    {
        public static IEnumerable<int> SimpleIterator()
        {
            for(int i = 1; i <= 5; i++)
            {
                yield return i;
            }
        }

        public static void PrintSimpleIterator()
        {
            foreach(int value in SimpleIterator())
            {
                Console.WriteLine(value);
            }
        }

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

        public static IEnumerable<int> FibonacciIterator(double candidate)
        {
            int current = 0;
            int next = 1;
            while(current < candidate)
            {
                yield return current;
                int oldCurrent = current;
                current = next;
                next = oldCurrent += next;
            }
        }

        public static List<int> FibonacciList(double candidate)
        {
            List<int> numbers = new List<int>();
            int current = 0;
            int next = 1;
            while(current < candidate)
            {
                numbers.Add(current);
                int oldCurrent = current;
                current = next;
                next = oldCurrent += next;
            }
            return numbers;
        }

        public static void PrintFibonnaciUpToValue(double candidate)
        {
            foreach(int value in Fibonacci()) 
            {
                if(value > candidate)
                {
                    break;
                }
                Console.WriteLine(value);
            }
        }

        public static void PrintFibonnaciListUpToValue(double candidate)
        {
            foreach(int value in FibonacciList(candidate)) 
            {
                Console.WriteLine(value);
            }
        }
    }
}
