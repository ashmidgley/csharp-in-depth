using NUnit.Framework;
using App;

namespace Tests
{
    public class GenericsTests
    {
        [Test]
        public void TestGenericsIntegerImplementations()
        {
            Assert.AreEqual(Generics.GenerateNumbersOld(), Generics.GenerateNumbersNew(), "Integer collections should match.");
        }

        [Test]
        public void TestGenericsStringImplementations()
        {
            Assert.AreEqual(Generics.GenerateNamesOld(), Generics.GenerateNamesNew(), "String collections should match.");
        }
    }
}
