using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    public static class IntializerEnhancements
    {
        public static void Usage()
        {
            // Prior to C# 6 initializers could only invoke property setters or set fields directly.
            string text = "testing testing";
            StringBuilder stringBuilderOld = new StringBuilder(text)
            {
                Length = 10
            };
            stringBuilderOld[0] = '\u2026';

            StringBuilder stringBuilderNew = new StringBuilder(text)
            {
                Length = 10,
                [0] = '\u2026'
            };

            Console.WriteLine(stringBuilderOld);
            Console.WriteLine(stringBuilderNew);

            // Collection intializer from C# 3. Throws exception if duplicate key.
            var collectionInitializer = new Dictionary<string, int>
            {
                { "A", 20 },
                { "B", 30 },
                { "C", 40 }
            };

            // C# 6 object intializer. Overwrites duplicate key. No problemo.
            var objectInitializer = new Dictionary<string, int>
            {
                ["A"] = 20,
                ["B"] = 30,
                ["A"] = 40
            };
        }
    }
}
