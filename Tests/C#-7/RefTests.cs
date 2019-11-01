using NUnit.Framework;
using App;

namespace Tests
{
    public class RefTests
    {
        [TestCase(new int[] { 1,5,2,4,3 })]
        public void TestSorts(int[] input)
        {
            var normalResult = Ref.NormalSort(input);
            Ref.RefSort(ref input);
            Assert.AreEqual(normalResult, input);
        }
    }
}
