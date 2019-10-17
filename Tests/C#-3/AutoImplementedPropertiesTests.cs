using NUnit.Framework;
using App;

namespace Tests
{
    public class AutoImplementedPropertiesTests
    {
        AutoImplementedProperties autoProps = new AutoImplementedProperties();

        [TestCase("Bart")]
        public void PropsShouldMatch(string input)
        {
            autoProps.NameOld = input;
            autoProps.NameNew = input;
            Assert.AreEqual(autoProps.NameOld, autoProps.NameNew, "Properties should match.");
        }
    }
}
