using PenappleWindowsApp.Api;
using PenappleWindowsApp.Helpers;
using PenappleWindowsApp.NavigationServices;
using PenappleWindowsApp.Views;
using PenscribCommon.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using PenscribCommon.Helpers;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml;
using Universal.UI.Xaml.Controls;
using Windows.Networking.PushNotifications;
using Windows.Data.Xml.Dom;

namespace PenappleWindowsApp.ViewModels
{
    /// <summary>
    /// GroupsViewModel
    /// 
    /// Contains logic for displaying groups in a scroll container.
    /// 
    /// author: Eric LaBouve
    /// </summary>
    public class GroupsViewModel : INotifyPropertyChanged
    {
        /* Required event object from INotifyPropertyChanged
         * 
         * Use the following line of code to notify the view when 
         * a property that has been binded to has changed:
         * PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("VARIABLE NAME")); 
         */
        public event PropertyChangedEventHandler PropertyChanged;

        // Button Actions
        public DelegateCommand addGroupCommand { get; private set; }
        //public DelegateCommand refreshGroupsCommand { get; private set; }
        public DelegateCommand homeCommand { get; private set; }
        public DelegateCommand switchToProfileCommand { get; private set; }
        public DelegateCommand switchToJournalsCommand { get; private set; }
        public DelegateCommand switchToGroupsCommand { get; private set; }
        public DelegateCommand changeGroupNameCommand { get; private set; }


        // Reference to the Navigation Service
        INavigationService navService;

        // instances of the user's groups
        private ObservableCollection<GroupsContent> journalList;
        private ObservableCollection<GroupsContent> convoList;


        // We have the choice to store images in the conversation as a collection
        private ObservableCollection<GroupsContent> _GroupsList;
        public ObservableCollection<GroupsContent> GroupsList
        {
            get { return _GroupsList; }
            set
            {
                _GroupsList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GroupsList"));
            }
        }

        private string journalTitle = "My Journal";
        private string groupsTitle = "Groups";

        // Text representing the title of screen
        private string _ScreenTitle;
        public string ScreenTitle
        {
            get { return _ScreenTitle; }
            set
            {
                _ScreenTitle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ScreenTitle"));
            }
        }

        // Progress ring loading for long running tasks
        private bool _loadingIndicator;
        public bool LoadingIndicator
        {
            get { return _loadingIndicator; }
            set
            {
                if (_loadingIndicator != value)
                {
                    _loadingIndicator = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LoadingIndicator"));
                }
            }
        }

        // Empty default group when there is no connection to the server
        private GroupChat defaultGroup = new GroupChat
        {
            id = "Local"
        };

        // Increments as more groups are added to the GroupsList
        private static int groupId = 1;
        // Max character length for group names
        private static readonly int maxCharacterLength = 20;

        /* Constructor
         * Loads all DelegateCommand objects for button clicks.
         */
        public GroupsViewModel()
        {
            navService = NavigationService.getNavigationServiceInstance();

            journalList = new ObservableCollection<GroupsContent>();
            convoList = new ObservableCollection<GroupsContent>();

            //retrieveGroupsFromServer();

            // display the user's groups by default
            switchToGroups();
        }

        /// <summary>
        /// Switch to the user's journal 
        /// </summary>
        public void switchToJournal()
        {
            retrieveGroupsFromServer();

            if (_ScreenTitle != journalTitle)
            {
                ScreenTitle = journalTitle;
                GroupsList = journalList;
            }
        }

        /// <summary>
        /// Switch to the user's groups 
        /// </summary>
        public void switchToGroups()
        {
            retrieveGroupsFromServer();

            if (_ScreenTitle != groupsTitle)
            {
                ScreenTitle = groupsTitle;
                GroupsList = convoList;
            }
        }

        public void resetGroups()
        {
            journalList.Clear();
            convoList.Clear();
        }

        /// <summary>
        /// Handles swipping the control left (delete) and right (rename)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">The GroupContent that was swipped</param>
        public async void itemSwiped(object sender, Universal.UI.Xaml.Controls.ItemSwipeEventArgs e)
        {
            var groupContent = e.SwipedItem as GroupsContent;
            if (groupContent != null)
            {
                if (e.Direction == SwipeListDirection.Left)
                {
                    await changeGroupNameAsync(groupContent);
                }
                else
                {
                    deleteGroup(groupContent);
                }

            }
        }

        /// <summary>
        /// Creates a popup box to allow the user to change the group name and then sends the 
        /// updated groupname to the server
        /// </summary>
        public async Task changeGroupNameAsync(GroupsContent groupContent)
        {
            if (App.User != null)
            {
                string currentGroupName = groupContent.group.Name;
                Tuple<Boolean, String> tup = await createGroupNameInputDialog();

                // User inputs
                Boolean cancelled = tup.Item1;
                string newGroupName = tup.Item2;
                if (!cancelled && newGroupName != "")
                {
                    GroupChat updatedGroup = await renameGroupChat(groupContent.group, newGroupName);
                    // Display message to user if the name change failed (no server)
                    if (updatedGroup == null)
                    {
                        ContentDialog noServerDialog = new ContentDialog()
                        {
                            Title = "Cannot change groupname",
                            Content = "Is your wifi down?",
                            PrimaryButtonText = "Ok"
                        };
                        await ContentDialogHelper.CreateContentDialogAsync(noServerDialog, true);
                    }
                    else
                    {
                        string members = await getGroupMemberNames(updatedGroup);
                        GroupsContent updatedContent = new GroupsContent(updatedGroup, members);
                        updatedContent.updateCanvasFrom(groupContent);

                        // Preserve ordering
                        int originalIndex = getGroupsContentIndex(groupContent.group.id);
                        GroupsList.Remove(groupContent);
                        GroupsList.Insert(originalIndex, updatedContent);

                        // if the user is currently looking at the group, update the group content message history
                        if (RightFrameNavigator.GetLastContext() != null &&
                            RightFrameNavigator.GetLastContext().Equals(groupContent.messageHistoryViewModel))
                        {
                            RightFrameNavigator.Navigate(typeof(MessageHistoryView), updatedContent.messageHistoryViewModel);
                        }
                    }
                }
            }
        }

        private async Task<Tuple<Boolean, String>> createGroupNameInputDialog()
        {
            Boolean cancelled = false;
            String groupName = "";
            ContentDialog enterGroupNameDialog = new ContentDialog()
            {
                Title = "Rename Group"
            };
            var panel = new StackPanel();
            TextBox groupNameBox = setTextBox("Enter a group name", "");
            groupNameBox.MaxLength = maxCharacterLength;
            panel.Children.Add(groupNameBox);
            enterGroupNameDialog.Content = panel;

            enterGroupNameDialog.PrimaryButtonText = "OK";
            enterGroupNameDialog.PrimaryButtonClick += delegate
            {
                groupName = groupNameBox.Text;
            };
            enterGroupNameDialog.SecondaryButtonText = "Cancel";
            enterGroupNameDialog.SecondaryButtonClick += delegate
            {
                cancelled = true;
            };
            await ContentDialogHelper.CreateContentDialogAsync(enterGroupNameDialog, true);
            return Tuple.Create(cancelled, groupName);
        }

        private async Task<Boolean> createDeleteGroupWarningDialog()
        {
            Boolean delete = false;
            ContentDialog deleteGroupWarningDialog = new ContentDialog()
            {
                Title = "You are about to delete this group",
                Content = "Are you sure you would like to proceed?"
            };
            deleteGroupWarningDialog.PrimaryButtonText = "Yes";
            deleteGroupWarningDialog.PrimaryButtonClick += delegate
            {
                delete = true;
            };
            deleteGroupWarningDialog.SecondaryButtonText = "No";
            deleteGroupWarningDialog.SecondaryButtonClick += delegate
            {
                delete = false;
            };
            await ContentDialogHelper.CreateContentDialogAsync(deleteGroupWarningDialog, true);
            return delete;
        }

        private async Task<Boolean> createLeaveGroupWarningDialog()
        {
            Boolean leave = false;
            ContentDialog leaveGroupWarningDialog = new ContentDialog()
            {
                Title = "You are about to leave this group.",
                Content = "Are you sure you would like to proceed?"
            };
            leaveGroupWarningDialog.PrimaryButtonText = "Yes";
            leaveGroupWarningDialog.PrimaryButtonClick += delegate
            {
                leave = true;
            };
            leaveGroupWarningDialog.SecondaryButtonText = "No";
            leaveGroupWarningDialog.SecondaryButtonClick += delegate
            {
                leave = false;
            };
            await ContentDialogHelper.CreateContentDialogAsync(leaveGroupWarningDialog, true);
            return leave;
        }

        protected virtual async Task<GroupChat> updateGroupChat(GroupChat group)
        {
            return await GroupChatApi.getInstance().updateGroupChat(group);
        }

        protected virtual async Task<GroupChat> renameGroupChat(GroupChat group, string newName)
        {
            return await GroupChatApi.getInstance().renameGroupChat(group, newName);
        }

        protected virtual async Task<HttpResponseMessage> deleteGroupChat(GroupChat group)
        {
            return await GroupChatApi.getInstance().leaveGroupChat(group, App.User.id);
        }

        public async void deleteGroup(GroupsContent groupContent)
        {
            int numMembers = groupContent.group.GroupMembers.Count;
            Boolean leaveOrDeleteGroup = false;
            // If there are more than 1 members in this group, we leave the chat
            if (numMembers > 1)
            {
                leaveOrDeleteGroup = await createLeaveGroupWarningDialog();
            }
            // If you are the last member in the group, we delete the group
            else
            {
                leaveOrDeleteGroup = await createDeleteGroupWarningDialog();
            }
            // Make rest call and refresh gui
            if (leaveOrDeleteGroup)
            {
                var res = await deleteGroupChat(groupContent.group);
                GroupsList.Remove(groupContent);

                // clear the right frame if the user is currently looking at the deleted group
                if (RightFrameNavigator.GetLastContext() != null
                    && RightFrameNavigator.GetLastContext().Equals(groupContent.messageHistoryViewModel))
                {
                    RightFrameNavigator.Navigate(typeof(MessageHistoryView));
                }
            }
            // refresh gui
            else
            {
                // Preserve ordering
                int originalIndex = getGroupsContentIndex(groupContent.group.id);
                GroupsList.Remove(groupContent);
                GroupsList.Insert(originalIndex, groupContent);
                //retrieveGroupsFromServer();
            }
        }

        /// <summary>
        /// Updates the frames to display the newly created group
        /// <param>groupContent: The newly created GroupsContent</param>
        public void displayNewGroup(GroupsContent groupContent)
        {
            bool frameVisible = LeftFrameNavigator.isSubFrameVisible();

            // determine whether to add the group to the group list or journal list
            // switch to that list
            if (groupContent.group.GroupMembers.Count == 1)
            {
                journalList.Add(groupContent);
                switchToJournal();
            }
            else
            {
                convoList.Add(groupContent);
                switchToGroups();
            }

            //display the new conversation in the proper frame
            if (frameVisible)
            {
                LeftFrameNavigator.NavigateSubFrame(typeof(MessageHistoryView), groupContent.messageHistoryViewModel);
                RightFrameNavigator.Navigate(typeof(MessageHistoryView), groupContent.messageHistoryViewModel);
                RightFrameNavigator.Navigate(typeof(CanvasPage), groupContent);
            }
            else
            {
                RightFrameNavigator.Navigate(typeof(MessageHistoryView), groupContent.messageHistoryViewModel);
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

        /// <summary>
        /// Enters a group conversation
        /// </summary>
        /// <param name="sender">A reference to the ListView (i think)</param>
        /// <param name="e">A reference to the GroupsContent</param>
        public void groupClicked(object sender, ItemClickEventArgs e)
        {
            GroupsContent group = (GroupsContent)e.ClickedItem;
            MessageHistoryViewModel view = group.messageHistoryViewModel;
            
            RightFrameNavigator.Navigate(typeof(MessageHistoryView), view);
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
        /// Obtains a unique group id
        /// </summary>
        /// <returns>group id as a string</returns>
        private string getAGroupId()
        {
            String idStr = groupId.ToString();
            groupId++;
            return idStr;
        }

        /// <summary>
        /// Add all groups associated with user to the GroupsList if user is logged in
        /// </summary>
        public async void retrieveGroupsFromServer()
        {
            System.Diagnostics.Debug.WriteLine("Retrieving groups");
            if (App.User != null)
            {
                GroupChatApi api = GroupChatApi.getInstance();
                IEnumerable<GroupChat> groups = await api.getGroupsForUser(App.User.id);

                LoadingIndicator = true;

                foreach (GroupChat g in groups)
                {
                    string members = await getGroupMemberNames(g);
                    GroupsContent group = new GroupsContent(g, members);

                    groupsListUpdate(group);
                }

                LoadingIndicator = false;
            }
        }

        public void handleRawNotification(RawNotification notification)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(notification.Content);

            XmlNodeList groupXml = doc.GetElementsByTagName("Group");
            XmlNodeList msgXml = doc.GetElementsByTagName("Message");
            XmlNodeList actionXml = doc.GetElementsByTagName("Action");
            if (groupXml.Any() && msgXml.Any())
            {
                string groupId = groupXml[0].InnerText;
                string action = actionXml[0].InnerText;

                if (action == "groupUpdate")
                {
                    retrieveGroupsFromServer();
                }
            }

        }

        /// <summary>
        /// Checks to see if the collection contains an instance of the group and checks if the group is updated 
        /// if so: removes the old instance
        /// Finally adds the group if not in the appropriate collection
        /// </summary>
        /// <param name="group">the group to update in the lists</param>
        /// <returns></returns>
        private void groupsListUpdate(GroupsContent group)
        {
            ObservableCollection<GroupsContent> contentList;

            // determine if the group is in a current list
            if (journalList.Contains(group))
            {
                contentList = journalList;
            }
            else if (convoList.Contains(group))
            {
                contentList = convoList;
            }
            else
            {
                contentList = null;
            }

            // check if the group has been updated
            if (contentList != null)
            {
                int oldGroupIndex = contentList.IndexOf(group);
                GroupsContent oldGroup = contentList[oldGroupIndex];
                group.updateCanvasFrom(oldGroup);

                // check if the group has been updated, if so remove the old instance
                if (oldGroup.isUpdated(group))
                {
                    contentList.Remove(group);
                }
            }

            // add the group to the appropriate list based on the number of group members
            if (group.group.GroupMembers.Count == 1 && !journalList.Contains(group))
            {
                journalList.Add(group);
            }
            else if (group.group.GroupMembers.Count > 1 && !convoList.Contains(group))
            {
                convoList.Add(group);
            }
        }

        /// <summary>
        /// Return groups content from the list with the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private GroupsContent getGroupsContent(string id)
        {
            foreach (GroupsContent gc in GroupsList)
            {
                if (gc.group.id == id)
                {
                    return gc;
                }
            }

            return null;
        }

        private int getGroupsContentIndex(string id)
        {
            int counter = 0;
            foreach (GroupsContent gc in GroupsList)
            {
                if (gc.group.id == id)
                {
                    return counter;
                }
                counter++;
            }

            return -1;
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

        // The methods below are taken from MessageHistoryViewModel
        // with minor adjustments

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
