using System;
using static System.Math;

namespace App
{
    /*  Tuples = Bag of variables.
        Single value tuple = Womple hahahaha. It's used in Tuples with arity 8: ValueTuple<int, int, int, int, int, int, int, ValueTuple<int>>.
        Nuple = non-generic tuple.
    */
    public static class Tuples
    {
        public static void Usage()
        {
            (int a, int b) tuple = (1, 2);
            var tupleTwo = (a: 1, b: 2);
            var a = 1;
            var b = 2;
            var tupleThree = (a, b);
            Console.WriteLine(tuple.a);
            Console.WriteLine(tuple.b);
            Console.WriteLine(tupleTwo.a);
            Console.WriteLine(tupleTwo.b);
            Console.WriteLine(tupleThree.a);
            Console.WriteLine(tupleThree.b);

            // Discards _. Used for desconstruction.
            var tup = (1, 2, 3, 4);
            var (x, y, _, _) = tup;
            Console.WriteLine(tup);
        }

        public static void Equality()
        {
            var left = (a: 100, b: "text");
            var right = (x: 100, y: "text");
            Console.WriteLine(left == right);
            Console.WriteLine(left != right);
        }

        public static (int min, int max) MinMax(int[] source)
        {
            (int Min, int Max) tuple = (source[0], source[0]);
            for(int i = 1; i < source.Length; i++)
            {
                if(Min(tuple.Min, source[i]) != tuple.Min)
                    tuple.Min = source[i];
                if(Max(tuple.Max, source[i]) != tuple.Max)
                    tuple.Max = source[i];
            }
            return tuple;
        }
    }
}
