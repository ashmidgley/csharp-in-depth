using NUnit.Framework;
using App;

namespace Tests
{
    public class TuplesTests
    {
        [TestCase(new int[]{ 5 ,6, 2, 8, 9, 3 }, ExpectedResult = 2, TestName = "Positive Input")]
        [TestCase(new int[]{ 0, 0, 0, 0, 0 }, ExpectedResult = 0, TestName = "Zeroes Input")]
        [TestCase(new int[]{ -10, -42, -30, -50, -5 }, ExpectedResult = -50, TestName = "Negative Input")]
        public int TestMin(int[] input)
        {
            return Tuples.MinMax(input).min;
        }

        [TestCase(new int[]{ 5 ,6, 2, 8, 9, 3 }, ExpectedResult = 9, TestName = "Positive Input")]
        [TestCase(new int[]{ 0, 0, 0, 0, 0 }, ExpectedResult = 0, TestName = "Zeroes Input")]
        [TestCase(new int[]{ -10, -42, -30, -50, -5 }, ExpectedResult = -5, TestName = "Negative Input")]
        public int TestMax(int[] input)
        {
            return Tuples.MinMax(input).max;
        }

        [TestCase(new int[] { 1, 2, 3, 4 })]
        public void TestDiscard(int[] input)
        {
            var (x, _, y, _) = (input[0], input[1], input[2], input[3]);
            Assert.AreEqual(x, input[0]);
            Assert.AreEqual(y, input[2]);
        }
    }
}
