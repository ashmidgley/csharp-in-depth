using NUnit.Framework;
using App;

namespace Tests
{
    public class ExtensionMethodsTests
    {
        [TestCase(new object[]{ "keys", "coat", "laptop", "bottle" })]
        public void QueryResultsMatch(params string[] input)
        {
            var queryOld = ExtensionMethods.QueryWithoutExtensionMethods(input);
            var queryNew = ExtensionMethods.QueryWithExtensionMethods(input);
            Assert.AreEqual(queryOld, queryNew, "Query results should match.");
        }
    }
}
