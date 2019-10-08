using NUnit.Framework;
using App;

namespace Tests
{
    public class NullCoalescingOperatorTests
    {
        [TestCase(1, null, 2)]
        public void ShouldReturnX(int? x, int? y, int z) 
        {
            var result = NullCoalescingOperator.ReturnNonNullValue(x, y, z);
            Assert.IsTrue(result == x, "Should return value x.");
        }

        [TestCase(null, 1, 2)]
        public void ShouldReturnY(int? x, int? y, int z) 
        {
            var result = NullCoalescingOperator.ReturnNonNullValue(x, y, z);
            Assert.IsTrue(result == y, "Should return value y.");
        }

        [TestCase(null, null, 1)]
        public void ShouldReturnZ(int? x, int? y, int z) 
        {
            var result = NullCoalescingOperator.ReturnNonNullValue(x, y, z);
            Assert.IsTrue(result == z, "Should return value z.");
        }
    }
}
