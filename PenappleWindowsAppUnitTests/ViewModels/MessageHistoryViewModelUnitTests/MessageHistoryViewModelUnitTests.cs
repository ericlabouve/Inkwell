using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using PenappleWindowsApp.ViewModels;
using PenscribCommon.Models;
using HyperMock;

namespace PenappleWindowsAppUnitTests.ViewModels.MessageHistoryViewModelUnitTests
{
    [TestClass]
    public class MessageHistoryViewModelUnitTests
    {
        [TestMethod]
        public void TestAddUsers()
        {
            //Setup
            TestableMessageHistoryViewModel viewmodel = new TestableMessageHistoryViewModel();
            GroupChat group = new GroupChat();

            //1. Test email does not exist
            group.id = null;
            viewmodel.setGroupChat(group);
            viewmodel.addUsers("DNE@microsoft.com");
            Assert.AreEqual(TestableMessageHistoryViewModel.contentDialogType.DNE, viewmodel.dialogType);

            //2. Test repeat member
            group.GroupMembers = new System.Collections.Generic.List<string>();
            group.GroupMembers.Add("RepeatMember@microsoft.com");
            viewmodel.setGroupChat(group);

            viewmodel.addUsers("RepeatMember@microsoft.com");
            Assert.AreEqual(TestableMessageHistoryViewModel.contentDialogType.RepeatMember, viewmodel.dialogType);

            //3. Test email exists, but failed to update server
            group.id = "Network Failure";
            group.GroupMembers = new System.Collections.Generic.List<string>();
            viewmodel.setGroupChat(group);

            viewmodel.addUsers("NetworkFailure@microsoft.com");
            Assert.AreEqual(TestableMessageHistoryViewModel.contentDialogType.NoServer, viewmodel.dialogType);

            //4. Test success
            group.id = "Success";
            group.GroupMembers = new System.Collections.Generic.List<string>();
            viewmodel.setGroupChat(group);

            viewmodel.addUsers("SuccessfulAdd@microsoft.com");
            Assert.AreEqual(TestableMessageHistoryViewModel.contentDialogType.SuccessfulAdd, viewmodel.dialogType);

            //5. Test invalid email
            group.id = null;
            viewmodel.setGroupChat(group);

            viewmodel.addUsers("InvalidEmailmicrosoft.com");
            Assert.AreEqual(TestableMessageHistoryViewModel.contentDialogType.InvalidEmail, viewmodel.dialogType);

        }
    }
}
