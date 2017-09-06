using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenappleWindowsApp.ViewModels;
using PenscribCommon.Models;
using PenappleWindowsAppUnitTests.ViewModels.MessageHistoryViewModelUnitTests;

namespace PenappleWindowsAppUnitTests.ViewModels.MessageHistoryViewModelUnitTests
{
    class TestableMessageHistoryViewModel : MessageHistoryViewModel
    {
        public contentDialogType dialogType { get; set; }

        public TestableMessageHistoryViewModel() : base()
        {
        }

        public void setGroupChat(GroupChat groupp)
        {
            base.group = groupp;
        }

        protected override async Task<User> getUserFromEmail(string user)
        {
            switch (user) {
                case "DNE@microsoft.com": return null;
                case "RepeatMember@microsoft.com":
                    User user1 = new User();
                    user1.id = "RepeatMember@microsoft.com";
                    return user1;
                case "SuccessfulAdd@microsoft.com":
                    User user2 = new User();
                    user2.id = "SuccessfulAdd@microsoft.com";
                    return user2;
                case "NetworkFailure@microsoft.com":
                    User user3 = new User();
                    user3.id = "NetworkFailure@microsoft.com";
                    return user3;
                default: return new User();
            }
        }
        
        protected override async Task<GroupChat> updateGroupChat(GroupChat group)
        {
            if (group.id.Equals("Network Failure", StringComparison.Ordinal))
                return null;
            else
                return group;
        }

        public override void displayContentDialogDispatch(contentDialogType type, String user)
        {
            dialogType = type;
        }
        
    }
}
