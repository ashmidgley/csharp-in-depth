using NUnit.Framework;
using App;

namespace Tests
{
    public class NullCoalescingOperatorTests
    {
        [TestCase(1, null, 2, ExpectedResult = 1)]
        [TestCase(null, 1, 2, ExpectedResult = 1)]
        [TestCase(null, null, 1, ExpectedResult = 1)]
        public int NullableCoalescingOperatorTest(int? x, int? y, int z) 
        {
            return NullCoalescingOperator.ReturnNonNullValue(x, y, z);
        }
    }
}
