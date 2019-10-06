using NUnit.Framework;
using PrimeLibrary;

namespace Tests
{
    [TestFixture]
    public class PrimeServiceTests
    {
        PrimeService primeService;

        [SetUp]
        public void Setup()
        {
            this.primeService = new PrimeService();
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsPrimeShouldReturnFalse(int value)
        {
            var result = primeService.isPrime(value);
            Assert.IsFalse(result, $"{value} should not be prime.");
        }

        [TestCase(2)]
        [TestCase(13)]
        [TestCase(997)]
        public void IsPrimeShouldReturnTrue(int value)
        {
            var result = primeService.isPrime(value);
            Assert.IsTrue(result, "7 should be prime.");
        }
    }
}