using NUnit.Framework;
using App;

namespace Tests
{
    public class QueryExpressionsTests
    {
        [TestCase(new object[] { "keys", "coat", "laptop", "bottle" })]
        public void QueryResultsMatch(params string[] input)
        {
            var methodChainingQuery = ExtensionMethods.QueryWithoutExtensionMethods(input);
            var queryExpressionQuery = QueryExpressions.CreateQuery(input);
            Assert.AreEqual(methodChainingQuery, queryExpressionQuery, "Query results should match.");
        }
    }
}
