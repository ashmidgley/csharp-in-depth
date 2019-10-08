using NUnit.Framework;
using App;
using System.Linq;

namespace Tests
{
    public class QueryExpressionsTests
    {
        string[] words = { "keys", "coat", "laptop", "bottle" };

        [Test]
        public void QueryResultsMatch()
        {
            var methodChainingQuery = ExtensionMethods.QueryWithoutExtensionMethods(this.words);
            var queryExpressionQuery = QueryExpressions.CreateQuery(this.words);
            Assert.IsTrue(methodChainingQuery.SequenceEqual(queryExpressionQuery), "Query results should match.");
        }
    }
}
