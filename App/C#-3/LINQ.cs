using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace App
{
    public static class LINQ
    {
        public static string[] words = new[] { "His", "name", "was", "Robert", "Paulson" };

        public static void Where()
        {
            var query = words
                .Where(word => word.Length < 4);
            PrintQuery(query);
        }

        public static void Select()
        {
            var query = words
                .Select(word => word.ToUpper());
            PrintQuery(query);
        }

        static void PrintQuery(IEnumerable query)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[ ");

            foreach(object s in query)
            {
                stringBuilder.Append($"'{s}' ");
            }
            stringBuilder.Append("]");
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}