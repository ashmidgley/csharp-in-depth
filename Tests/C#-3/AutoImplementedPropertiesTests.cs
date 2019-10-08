using NUnit.Framework;
using App;

namespace Tests
{
    public class AutoImplementedPropertiesTests
    {
        AutoImplementedProperties autoProps = new AutoImplementedProperties();

        [Test]
        public void PropsShouldMatch()
        {
            autoProps.NameOld = "Bart";
            autoProps.NameNew = "Bart";
            Assert.IsTrue(autoProps.NameOld.Equals(autoProps.NameNew), "Properties should match.");
        }
    }
}
