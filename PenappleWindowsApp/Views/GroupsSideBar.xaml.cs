using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using PenappleWindowsApp.NavigationServices;
using PenappleWindowsApp.Helpers;
using PenscribCommon.Models;
using PenappleWindowsApp.Api;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PenappleWindowsApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class GroupsSideBar : Page
    {
        // Empty default group when there is no connection to the server
        private GroupChat defaultGroup = new GroupChat
        {
            id = "Local"
        };

        public GroupsSideBar()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            LeftFrameNavigator.Navigate(typeof(GroupsView), "groups");
            RightFrameNavigator.Navigate(typeof(MessageHistoryView));

            if (LeftFrameNavigator.isSubFrameVisible())
            {
                LeftFrameNavigator.ClearSubFrame();
            }

            if (ProfileNavigator.isFrameVisible())
            {
                ProfileNavigator.ClearFrame();
                ProfileButton.Visibility = Visibility.Visible;
                BackButton.Visibility = Visibility.Collapsed;
            }
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            ProfileNavigator.Navigate(typeof(ProfilePageView));
            ProfileButton.Visibility = Visibility.Collapsed;
            BackButton.Visibility = Visibility.Visible;
        }
        
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ProfileNavigator.ClearFrame();
            ProfileButton.Visibility = Visibility.Visible;
            BackButton.Visibility = Visibility.Collapsed;
        }

        private void JournalButton_Click(object sender, RoutedEventArgs e)
        {
            LeftFrameNavigator.Navigate(typeof(GroupsView), "journal");
            
            if (LeftFrameNavigator.isSubFrameVisible())
            {
                LeftFrameNavigator.ClearSubFrame();
                RightFrameNavigator.NavigateToLastMessageHistory();
            }

            if (ProfileNavigator.isFrameVisible())
            {
                ProfileNavigator.ClearFrame();
                ProfileButton.Visibility = Visibility.Visible;
                BackButton.Visibility = Visibility.Collapsed;
            }
        }

        private void GroupsButton_Click(object sender, RoutedEventArgs e)
        {
            LeftFrameNavigator.Navigate(typeof(GroupsView), "groups");

            if (LeftFrameNavigator.isSubFrameVisible())
            {
                LeftFrameNavigator.ClearSubFrame();
                RightFrameNavigator.NavigateToLastMessageHistory();
            }

            if (ProfileNavigator.isFrameVisible())
            {
                ProfileNavigator.ClearFrame();
                ProfileButton.Visibility = Visibility.Visible;
                BackButton.Visibility = Visibility.Collapsed;
            }
        }

        private void AddGroupButton_Click(object sender, RoutedEventArgs e)
        {
            addGroup();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ProfileButton.Visibility = Visibility.Visible;
            BackButton.Visibility = Visibility.Collapsed;
        }

        private async void addGroup()
        {
            GroupsContent group;

            // Groups can only be retrieved if user is logged in
            if (App.User != null)
            {
                Boolean cancelled = false;
                String groupName = "";
                String groupMembers = "";
                //enterGroupNameDialog reference: 
                // https://www.reflectionit.nl/blog/2015/windows-10-xaml-tips-messagedialog-and-contentdialog

                ContentDialog enterGroupNameDialog = new ContentDialog()
                {
                    Title = "Create a new group"
                };
                var panel = new StackPanel();

                // create the text box for user to set a group name
                TextBox groupNameBox = setTextBox("Enter a group name (max 20 characters)", "");
                // create the text box for user to add initial group members
                TextBox groupMemberBox = setTextBox("Enter user emails", "Separate multiple emails with a space...");

                // add the textboxes to the stackpanel
                panel.Children.Add(groupNameBox);
                panel.Children.Add(groupMemberBox);

                enterGroupNameDialog.Content = panel;

                enterGroupNameDialog.PrimaryButtonText = "Create";
                enterGroupNameDialog.PrimaryButtonClick += delegate
                {
                    groupName = groupNameBox.Text;
                    groupMembers = groupMemberBox.Text;
                };
                enterGroupNameDialog.SecondaryButtonText = "Cancel";
                enterGroupNameDialog.SecondaryButtonClick += delegate
                {
                    cancelled = true;
                };
                await ContentDialogHelper.CreateContentDialogAsync(enterGroupNameDialog, true);

                if (!cancelled)
                {
                    if (groupName != "")
                    {
                        // initial list of users in group includes the logged in user and the groupMembers specified in groupMemberBox
                        List<string> users = await setInitialUserList(groupMembers);

                        GroupChat newGroup = new PenscribCommon.Models.GroupChat
                        {
                            GroupMembers = users,
                            CreationDate = DateTime.Now,
                            Name = groupName
                        };

                        GroupChatApi api = GroupChatApi.getInstance();
                        GroupChat createdGroup = await api.postGroupChat(newGroup);

                        // Show error if group was unable to be posted to the server
                        if (createdGroup == null)
                        {
                            ContentDialog errorDialog = new ContentDialog()
                            {
                                Title = "Unable to sync group with server",
                                Content = "You are not connected to the server and so the group could not be pushed",
                                PrimaryButtonText = "Ok"
                            };

                            await ContentDialogHelper.CreateContentDialogAsync(errorDialog, true);
                            group = new GroupsContent(defaultGroup, "");
                        }
                        else
                        {
                            string members = await getGroupMemberNames(createdGroup);
                            group = new GroupsContent(createdGroup, members);
                        }

                        // update the content in the view
                        //displayNewGroup(group);
                        LeftFrameNavigator.Navigate(typeof(GroupsView), group);
                    }
                    else
                    {
                        ContentDialog invalidGroupNameDialog = new ContentDialog()
                        {
                            Title = "Invalid group name",
                            Content = "Please enter a group name",
                            PrimaryButtonText = "Ok"
                        };
                        await ContentDialogHelper.CreateContentDialogAsync(invalidGroupNameDialog, true);
                        addGroup();
                    }
                }
            }
            else
            {
                ContentDialog notLoggedInDialog = new ContentDialog()
                {
                    Title = "Not logged in",
                    Content = "You are not logged in and cannot sync with the server",
                    PrimaryButtonText = "Ok"
                };

                await ContentDialogHelper.CreateContentDialogAsync(notLoggedInDialog, true);

                group = new GroupsContent(defaultGroup, "");

                // update the content in the view
                //displayNewGroup(group);
                LeftFrameNavigator.Navigate(typeof(GroupsView), defaultGroup);
            }
        }

        /// <summary>
        /// Sets a textbox given the name and placeholder
        /// <param>header: string representing the header of the textbox </param>
        /// <param>placeholder: string representing the placeholder of the textbox </param>
        /// <returns>The updated textbox</returns>
        public TextBox setTextBox(String header, String placeholder)
        {
            TextBox box = new TextBox();
            box.Header = header;
            box.PlaceholderText = placeholder;

            // Set a bottom margin to separate this textbox from others
            Thickness margin = box.Margin;
            margin.Top = 15;
            box.Margin = margin;

            return box;
        }

        public async Task<string> getGroupMemberNames(GroupChat group)
        {
            UserApi userApi = UserApi.getInstance();
            string members = "";

            for (int i = 0; i < group.GroupMembers.Count; i++)
            {
                User user = await userApi.getUser(group.GroupMembers[i]);

                if (user != null)
                {
                    if (i == group.GroupMembers.Count - 1)
                    {
                        members += user.FirstName + System.Environment.NewLine;
                    }
                    else
                    {
                        members += user.FirstName + ", ";
                    }
                }
            }

            return members;
        }

        /// <summary>
        /// Determines the users to add to a list
        /// <param name="members"></param>
        /// <returns>returns a list of user ids</returns>
        /// </summary>
        private async Task<List<string>> setInitialUserList(string members)
        {
            // separate input based on space
            char[] separators = { ' ', '\t', '\n' };
            List<string> users = new List<string>();

            // add the current user's id to the list
            users.Add(App.User.id);

            string[] userEmails = members.Split(separators);

            // check if any emails were supplied
            if (userEmails[0] != "")
            {
                //process the rest of the emails
                foreach (string email in userEmails)
                {
                    if (isValidEmail(email))
                    {
                        User user = await getUserFromEmail(email);

                        // Display a dialog stating the user does not exist
                        if (user == null)
                        {
                            displayContentDialogDispatch(contentDialogType.DNE, email);
                        }
                        else if (users.Contains(user.id))
                        {
                            displayContentDialogDispatch(contentDialogType.RepeatMember, email);
                        }
                        else
                        {
                            users.Add(user.id);
                        }
                    }
                    else
                    {
                        displayContentDialogDispatch(contentDialogType.InvalidEmail, email);
                    }
                }
            }

            return users;
        }

        /// <summary>
        /// Helper function to check if input is a valid email form
        /// </summary>
        /// <param name="user">email to check</param>
        /// <returns></returns>
        private Boolean isValidEmail(String user)
        {
            if (user.Contains("@") && user.Contains("."))
            {
                return true;
            }

            return false;
        }

        protected virtual async Task<User> getUserFromEmail(string user)
        {
            return await UserApi.getInstance().getUserByEmail(user);
        }

        public enum contentDialogType { DNE, InvalidEmail, RepeatMember, NoServer, SuccessfulAdd, NoEmail }
        /**
         * Method for dispatching a particular dialog depending on the contentDialogType parameter.
         * The user is the user name which is required for the dialog message content.
         */
        public virtual async void displayContentDialogDispatch(contentDialogType type, String user)
        {
            switch (type)
            {
                case contentDialogType.DNE:
                    ContentDialog userInGroupDialog = new ContentDialog()
                    {
                        Title = "User Not Added",
                        Content = user + " does not exist.",
                        PrimaryButtonText = "Ok"
                    };
                    await ContentDialogHelper.CreateContentDialogAsync(userInGroupDialog, true);
                    break;
                case contentDialogType.InvalidEmail:
                    ContentDialog invalidUserEmailDialog = new ContentDialog()
                    {
                        Title = "User Not Added",
                        Content = user + " is not a valid email address form.",
                        PrimaryButtonText = "Ok"
                    };
                    await ContentDialogHelper.CreateContentDialogAsync(invalidUserEmailDialog, true);
                    break;
                case contentDialogType.RepeatMember:
                    ContentDialog repeatMemberDialog = new ContentDialog()
                    {
                        Title = "User Not Added",
                        Content = user + " already in group.",
                        PrimaryButtonText = "Ok"
                    };
                    await ContentDialogHelper.CreateContentDialogAsync(repeatMemberDialog, true);
                    break;
                case contentDialogType.NoServer:
                    ContentDialog noServerDialog = new ContentDialog()
                    {
                        Title = "User Not Added",
                        Content = "Could not sync group with server.",
                        PrimaryButtonText = "Ok"
                    };
                    await ContentDialogHelper.CreateContentDialogAsync(noServerDialog, true);
                    break;
                case contentDialogType.SuccessfulAdd:
                    ContentDialog successDialog = new ContentDialog()
                    {
                        Title = user + " Successfully Added!",
                        Content = "You will now be able to chat with " + user,
                        PrimaryButtonText = "Ok"
                    };
                    await ContentDialogHelper.CreateContentDialogAsync(successDialog, true);
                    break;
                case contentDialogType.NoEmail:
                    ContentDialog noEmailDialog = new ContentDialog()
                    {
                        Title = "No User Added",
                        Content = "Please enter an email address",
                        PrimaryButtonText = "Ok"
                    };
                    await ContentDialogHelper.CreateContentDialogAsync(noEmailDialog, true);
                    break;
            }
        }
    }
}
