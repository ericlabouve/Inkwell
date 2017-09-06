using System;
using Windows.UI.Xaml.Controls;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using PenappleWindowsApp.ViewModels;

namespace PenappleWindowsAppUnitTests.ViewModels
{
    [TestClass]
    public class GroupsViewModelUnitTests
    {
        [TestMethod]
        public void TestSetTextBox()
        {
            GroupsViewModel gvm = new GroupsViewModel();
            TextBox expectedBox = new TextBox();
            expectedBox.Header = "Test Header";
            expectedBox.PlaceholderText = "Placeholder here";

            Assert.AreEqual(expectedBox, gvm.setTextBox("Test Header", "Placeholder here"));

            Assert.AreNotEqual(expectedBox, gvm.setTextBox("Test", "Placeholder here"));
        }
    }
}
