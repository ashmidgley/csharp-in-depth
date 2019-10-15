using System;

namespace App
{
    // Pragma directives give extra info to the compiler.
    public static class PragmaDirectives
    {
        public static void Usage()
        {
            // CS0219 is the warning for unused variables.
            #pragma warning disable CS0219
            var x = "Unused variable.";
            Console.WriteLine("Haha try and complain now you silly compiler.");
            #pragma warning restore CS0219
        }
    }
}
