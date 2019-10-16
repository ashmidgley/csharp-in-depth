using NUnit.Framework;
using App;
using System.Linq;
using System;

namespace Tests
{
    public class IteratorsTests
    {
        [TestCase(1000, new []{0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987})]
        public void FibonacciIteratorMatchesExpected(double input, int[] expected)
        {
            int[] result = Iterators.FibonacciIterator(input).ToList().ToArray();
            Assert.IsTrue(ArraysMatch(result, expected), "Resulting list doesn't match expected.");
        }

        [TestCase(1000, new []{0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987})]
        public void FibonacciListMatches(double input, int[] expected)
        {
            int[] result = Iterators.FibonacciIterator(input).ToArray();
            Assert.IsTrue(ArraysMatch(result, expected), "Resulting list doesn't match expected.");
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

        private bool ArraysMatch(int[] arrayOne, int[] arrayTwo)
        {
            if(arrayOne.Length != arrayTwo.Length)
            {
                return false;
            }
            for(int i = 0; i < arrayOne.Length; i++)
            {
                if(arrayOne[i] != arrayTwo[i])
                { 
                    return false;
                }
            }
            return true;
        }
    }
}
