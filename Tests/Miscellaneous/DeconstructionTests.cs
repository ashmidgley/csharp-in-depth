using NUnit.Framework;
using App;

namespace Tests
{
    public class DesconstructionTests
    {
        [TestCase(10, 20)]
        public void DeconstructValueShouldMatch(double x, double y)
        {
            Deconstruction test = new Deconstruction(x, y);
            var (a, b) = test;
            Assert.IsTrue(a == x, "Value a does not match test value x.");
            Assert.IsTrue(b == y, "Value b does not match test value y.");
        }
    }
}
