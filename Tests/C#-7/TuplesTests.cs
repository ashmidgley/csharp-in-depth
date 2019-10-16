using NUnit.Framework;
using App;

namespace Tests
{
    public class TuplesTests
    {
        [TestCase(2, 9, new int[]{ 5 ,6, 2, 8, 9, 3 })]
        [TestCase(0, 0, new int[]{ 0, 0, 0, 0, 0 })]
        [TestCase(-50, -5, new int[]{ -10, -42, -30, -50, -5 })]
        public void TestMinMax(int expectedMin, int expectMax, int[] input)
        {
            (int Min, int Max) result = Tuples.MinMax(input);
            Assert.IsTrue(result.Min == expectedMin, "Incorrect minimum value.");
            Assert.IsTrue(result.Max == expectMax, "Incorrect maximum value.");
        }
    }
}
