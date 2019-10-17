using NUnit.Framework;
using App;
using System.Linq;
using System;

namespace Tests
{
    public class IteratorsTests
    {
        [TestCase(1000, ExpectedResult = new []{0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987})]
        public int[] FibonacciIteratorMatchesExpected(double input)
        {
            return Iterators.FibonacciIterator(input).ToArray();
        }

        [TestCase(1000, ExpectedResult = new []{0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987})]
        public int[] FibonacciListMatches(double input)
        {
            return Iterators.FibonacciIterator(input).ToArray();
        }

        [TestCase(10000000000)]
        [TestCase(10000000000000000000)]
        public void IteratorMethodLargeInputShouldRun(double input)
        {
            Assert.DoesNotThrow(
                () => Iterators.FibonacciIterator(input), 
                "Call with large input should not throw.");
        }

        [TestCase(10000000000)]
        public void ListMethodLargeInputShouldThrow(double input)
        {
            Assert.Throws<OutOfMemoryException>(
                () => Iterators.FibonacciList(input),
                "Call with large input should throw OutOfMemoryException.");
        }
    }
}
