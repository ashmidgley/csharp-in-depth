using NUnit.Framework;
using App;
using System;
using System.Linq;

namespace Tests
{
    public class ExtensionMethodsTests
    {
        string[] words = { "keys", "coat", "laptop", "bottle" };

        [Test]
        public void QueryResultsMatch()
        {
            var queryOld = ExtensionMethods.QueryWithoutExtensionMethods(this.words);
            var queryNew = ExtensionMethods.QueryWithExtensionMethods(this.words);
            Assert.IsTrue(queryOld.SequenceEqual(queryNew), "Query results should match.");
        }
    }
}
