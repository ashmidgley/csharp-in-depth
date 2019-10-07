using NUnit.Framework;
using App;

namespace Tests
{
    public class GenericsTests
    {
        [Test]
        public void OldIntegerCollectionMatchesNewImplementation()
        {
            bool result = Generics.CollectionsMatch(Generics.GenerateNumbersOld(), Generics.GenerateNumbersNew());
            Assert.IsTrue(result, "Integer collections should match.");
        }

        [Test]
        public void OldStringCollectionMatchesNewImplementation()
        {
            bool result = Generics.CollectionsMatch(Generics.GenerateNamesOld(), Generics.GenerateNamesNew());
            Assert.IsTrue(result, "String collections should match.");
        }
    }
}