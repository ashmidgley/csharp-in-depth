using System;

namespace App
{
    /*
        The primary aim of the ref-related features is for performance.
        If you're not writing performance critical code, you may not need to use many of these features.
    */
    public static class Ref
    {
        public static void SimpleExample()
        {
            int x = 5;
            IncrementAndDouble(ref x, ref x);
            Console.WriteLine(x);

            ref int y = ref RefReturn(ref x);
            Console.WriteLine(y);
        }

        private static void IncrementAndDouble(ref int p1, ref int p2)
        {
            p1++;
            p2 *= 2;
        }

        public static void RefLocal()
        {
            var array = new (int x, int y)[10];
            for(int i=0; i < array.Length; i++)
            {
                array[i] = (i, i);
            }
            for(int i=0; i < array.Length; i++)
            {
                ref var element = ref array[i];
                element.x++;
                element.y *= 2;

                /* 
                Alternative is:
                array[i].x++;
                array[i].y *= 2;
                OR
                var tuple = array[i];
                tuple.x++;
                tuple.y *= 2;
                array[i] = tuple;
                */
            }
        }

        public static ref int RefReturn(ref int p)
        {
            return ref p;
        }

        public static void RefSort(ref int[] input)
        {
            Array.Sort(input);
        }

        public static int[] NormalSort(int[] input)
        {
            Array.Sort(input);
            return input;
        }
        
        public static void ArrayHolderUsage()
        {
            Example example = new Example();
            ref int elementOne = ref example[0];
            ref int elementOneAswell = ref example[0];

            elementOne = 100;
            Console.WriteLine(elementOneAswell);
        }
    }

    class Example
    {
        private int[] array = new int[10];

        public ref int this[int index]
        {
            get 
            {
                return ref array[index];
            }
        }
    }
}
