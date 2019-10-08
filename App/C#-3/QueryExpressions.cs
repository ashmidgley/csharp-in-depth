using System.Linq;
using System.Collections.Generic;

namespace App
{
    public static class QueryExpressions
    {
        public static IEnumerable<string> CreateQuery(string[] words)
        {
            var query = 
                from word in words
                where word.Length > 4
                orderby word
                select word.ToUpper();
            return query;
        }

        public static void SimpleQueryExample()
        {
            string[] words = { "keys", "coat", "laptop", "bottle" };

            // Query expressions require you to start with a from clause and end with either a select or group by 
            // making simple queries over-complicated in comparison to the method chaining technique.

            var queryExpression = 
                from word in words
                where word.Length > 4
                select word;

            var methodChaining = words
                .Where(word => word.Length > 4);
        }
    }
}
