using NUnit.Framework;
using App;

namespace Tests
{
    public class CallerInformationAttributesTests
    {      
        [Test]
        public void DefaultValues()
        {
            var result = CallerInformationAttributes.ExampleUsage();
            Assert.IsTrue(result.file.Equals("/home/ash/dev/miscellaneous/Tests/C#-5/CallerInformationAttributesTests.cs"), "File path received does not match expected result.");
            Assert.IsTrue(result.line == 11, "Line number received does not match expected result.");
            Assert.IsTrue(result.member.Equals("DefaultValues"), "Member received does not match expected result.");
        }

        [Test]
        public void ExplicitValueForFile()
        {
            string dummyFileName = "EatMyShorts.cs";
            var result = CallerInformationAttributes.ExampleUsage(file: dummyFileName);
            Assert.IsTrue(result.file.Equals(dummyFileName), "File path received does not match expected result.");
            Assert.IsTrue(result.line == 21, "Line number received does not match expected result.");
            Assert.IsTrue(result.member.Equals("ExplicitValueForFile"), "Member received does not match expected result.");
        }
    }
}
