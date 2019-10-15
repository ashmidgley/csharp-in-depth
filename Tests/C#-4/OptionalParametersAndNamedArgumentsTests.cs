using NUnit.Framework;
using App;

namespace Tests
{
    public class OptionalParametersAndNamedArgumentsTests
    {
        string message = "Call with named arguments and default values should not throw exception.";

        [Test]
        public void NoNamedParameters()
        {
            Assert.DoesNotThrow(() => OptionalParametersAndNamedArguments.Usage(1, 2, 3), message);
            
        }

        [Test]
        public void JustX()
        {
            Assert.DoesNotThrow(() => OptionalParametersAndNamedArguments.Usage(1), message);
            
        }

        [Test]
        public void AllNamedUnordered()
        {
            Assert.DoesNotThrow(() => OptionalParametersAndNamedArguments.Usage(z: 1, x: 2, y: 3), message);
            
        }

        [Test]
        public void NamedXAndZDefaultY()
        {
            Assert.DoesNotThrow(() => OptionalParametersAndNamedArguments.Usage(x: 1, z: 2), message);
            
        }
    }
}
