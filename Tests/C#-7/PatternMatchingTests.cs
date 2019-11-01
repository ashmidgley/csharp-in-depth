using NUnit.Framework;
using App;
using System;

namespace Tests
{
    public class PatternMatchingTests
    {
        Rectangle Rectangle = new Rectangle(2, 5);
        Square Square = new Square();

        [Test]
        public void TestNewTypePattern()
        {
            Assert.AreEqual(PatternMatching.TypePattern(Rectangle), 20);
            Assert.Throws<ArgumentException>(() => PatternMatching.TypePattern(Square));
        }

        [Test]
        public void TestOldTypePattern()
        {
            Assert.AreEqual(PatternMatching.TypePatternOld(Rectangle), 20);
            Assert.Throws<ArgumentException>(() => PatternMatching.TypePatternOld(Square));
        }
    }
}

