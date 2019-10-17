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
            (int x, string y) tuple = (x: 1, "Test");
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            tuple.x = 2;
            tuple.y = "Updated";
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            tuple = (3, "Updated x 2");
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);

            var valid = (x: 1, "Test");
            var validAswell = new[] { valid };

            Console.WriteLine(tuple == valid);

            var t1 = (1, 2);
            var t2 = (1, 2);
            Console.WriteLine(t1 == t2);

            var tupley = new ValueTuple<int, bool>(1, true);
            Console.WriteLine(tupley);
            Console.WriteLine(tupley.ToString());

            var tuplino = ValueTuple.Create(1, "Test");
            Console.WriteLine(tuplino.Item1);
            Console.WriteLine(tuplino.Item2);

            // Discards _. Used for desconstruction.
            var tup = (1, 2, 3, 4);
            var (x, y, _, _) = tup;
            Console.WriteLine(tup);
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
