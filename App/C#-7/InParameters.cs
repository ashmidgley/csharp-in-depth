using System;

namespace App
{
    /* 
        Added as a new parameter in C# 7.2. Similar to ref and out references but the intention is the method won't change the parameter value.
        The point of in parameters is to improve performance by reducing copying for structs.
        Note: SKeety hasn't used them in code yet so we probably won't see common usage of these for a while.
    */
    public static class InParameters
    {
        public static void Usage()
        {
            int x = 5;
            Overloading(x);
            Overloading(in x);
        }

        public static void Overloading(int x)
        {
            Console.WriteLine($"Overloading(int x) called.");
        }

        public static void Overloading(in int x)
        {
            Console.WriteLine($"Overloading(in int x) called.");
        }
    }
}
