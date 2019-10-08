using System.Collections.Generic;
using System.Linq;

namespace App
{
    // Extension methods allow you to call static methods as if they're instance methods.
    // Eg: ExampleClass.Method(x, y) would become x.Method(y).
    public static class ExtensionMethods
    {
        public static List<string> JoeyWasHere(this List<string> collection)
        {
            for(int i = 0; i < collection.Count; i++)
            {
                collection[i] = "How you doin'?";
            }
            return collection;
        }

        public static IEnumerable<string> QueryWithoutExtensionMethods(string[] words)
        {
            var queryOne = 
                Enumerable.Select(
                    Enumerable.OrderBy(
                        Enumerable.Where(words, word => word.Length > 4),
                        word => word),
                    wordList => wordList.ToUpper());

            var tmp1 = Enumerable.Where(words, word => word.Length > 4);
            var tmp2 = Enumerable.OrderBy(tmp1, word => word);
            var queryTwo = Enumerable.Select(tmp2, word => word.ToUpper());
            return queryTwo;
        }

        public static IEnumerable<string> QueryWithExtensionMethods(string[] words)
        {
            var query = words
                .Where(word => word.Length > 4)
                .OrderBy(word => word)
                .Select(word => word.ToUpper());
            return query;
        }
    }
}
