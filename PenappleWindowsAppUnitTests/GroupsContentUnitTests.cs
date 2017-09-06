using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using PenappleWindowsApp;

namespace PenappleWindowsAppUnitTests
{
    [TestClass]
    public class GroupsContentUnitTests
    {
        [TestMethod]
        public void TestSetGroupIcon()
        {
            Assert.AreEqual("GC", GroupsContent.getGroupIconChars(null));
            Assert.AreEqual("GC", GroupsContent.getGroupIconChars(""));
            Assert.AreEqual("GC", GroupsContent.getGroupIconChars("   "));
            Assert.AreEqual("T", GroupsContent.getGroupIconChars("Test"));
            Assert.AreEqual("LG", GroupsContent.getGroupIconChars("Longer group title"));
            Assert.AreEqual("TW", GroupsContent.getGroupIconChars("   title with spaces   "));
            Assert.AreEqual("T", GroupsContent.getGroupIconChars("\nTitle"));
        }
    }
}