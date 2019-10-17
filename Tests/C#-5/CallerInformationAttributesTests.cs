using NUnit.Framework;
using App;

namespace Tests
{
    public class CallerInformationAttributesTests
    {      
        [Test]
        public void DefaultValues()
        {
            var result = CallerInformationAttributes.Usage();
            Assert.AreEqual(result.file, "/home/ash/dev/miscellaneous/Tests/C#-5/CallerInformationAttributesTests.cs", "File path received does not match expected result.");
            Assert.AreEqual(result.line, 11, "Line number received does not match expected result.");
            Assert.AreEqual(result.member, "DefaultValues", "Member received does not match expected result.");
        }

        [Test]
        public void ExplicitValueForFile()
        {
            string dummyFileName = "EatMyShorts.cs";
            var result = CallerInformationAttributes.Usage(file: dummyFileName);
            Assert.AreEqual(result.file, dummyFileName, "File path received does not match expected result.");
            Assert.AreEqual(result.line, 21, "Line number received does not match expected result.");
            Assert.AreEqual(result.member, "ExplicitValueForFile", "Member received does not match expected result.");
        }
    }
}
