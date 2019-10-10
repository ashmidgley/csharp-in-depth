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
            Assert.DoesNotThrow(() => OptionalParametersAndNamedArguments.ExampleUsage(1, 2, 3), message);
            
        }

        [Test]
        public void JustX()
        {
            Assert.DoesNotThrow(() => OptionalParametersAndNamedArguments.ExampleUsage(1), message);
            
        }

        [Test]
        public void AllNamedUnordered()
        {
            Assert.DoesNotThrow(() => OptionalParametersAndNamedArguments.ExampleUsage(z: 1, x: 2, y: 3), message);
            
        }

        [Test]
        public void NamedXAndZDefaultY()
        {
            Assert.DoesNotThrow(() => OptionalParametersAndNamedArguments.ExampleUsage(x: 1, z: 2), message);
            
        }
    }
}
