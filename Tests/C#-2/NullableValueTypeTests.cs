using NUnit.Framework;
using App;

namespace Tests
{
    public class NullableValueTypeTests
    {
        [Test]
        public void ShouldHaveValue()
        {
            var result = NullableValueTypes.GenerateOrderWithCompanyId();
            Assert.IsTrue(result.CompanyId.HasValue, "Nullable type should have value.");
        }

        [Test]
        public void ShouldNotHaveValue()
        {
            var result = NullableValueTypes.GenerateOrderWithoutCompanyId();
            Assert.IsFalse(result.CompanyId.HasValue, "Nullable type should not have value.");
        }
    }
}
