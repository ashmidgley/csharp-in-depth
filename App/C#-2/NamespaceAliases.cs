using System;
using Generic = System.Collections.Generic;
using Genny = System.Collections.Generic;

namespace App
{
    public static class NamespaceAliases
    {
        public static void PrintAliasTypes()
        {
            Console.WriteLine(typeof(Generic.List<int>));
            Console.WriteLine(typeof(Genny.List<int>));

            // Namespace alias qualifiers introduced in C# 2. Use these over the above example.
            Console.WriteLine(typeof(Generic::List<int>));
            Console.WriteLine(typeof(Genny::List<int>));
        }
    }
}
