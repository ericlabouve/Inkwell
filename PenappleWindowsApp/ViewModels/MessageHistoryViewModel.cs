using PenappleWindowsApp.NavigationServices;
using PenappleWindowsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage;
using Windows.Storage.Streams;
using System.IO;
using PenscribCommon.Helpers;
using PenscribCommon.Models;
using System.Diagnostics;
using PenappleWindowsApp.Api;
using System.Collections.Specialized;
using Windows.UI.Xaml.Media;
using WinRTXamlToolkit.Controls.Extensions;
using PenappleWindowsApp.Helpers;
using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;
using PenappleWindowsApp.Views;
using Windows.Networking.PushNotifications;

namespace PenappleWindowsApp.ViewModels
{
    /// <summary>
    /// MessageHistoryViewModel
    /// 
    /// Contains logic for displaying gifs (V2: .svg) in a scroll container.
    /// 
    /// author: Eric LaBouve
    /// co-author: Jason Chin
    /// </summary>
    public class MessageHistoryViewModel : INotifyPropertyChanged
    {
        /* Required event object from INotifyPropertyChanged
         * 
         * Use the following line of code to notify the view when 
         * a property that has been binded to has changed:
         * PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("VARIABLE NAME")); 
         */
        public event PropertyChangedEventHandler PropertyChanged;

        // Button Actions
        public DelegateCommand composeCommand { get; private set; }
        public DelegateCommand receiveCommand { get; private set; }
        public DelegateCommand sendTextCommand { get; private set; }
        public DelegateCommand addCommand { get; private set; }

        // Reference to the Navigation Service
        INavigationService navService;

        // Reference to the model
        private MessageHistoryModel model;

        protected GroupsContent group;
        
        // We have the choice to store images in the conversation as a collection
        private ChatHistory _history;
        public ChatHistory History
        {
            get { return _history; }
            set
            {
                _history = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("History"));
            }
        }

        // Binding for the group name in the MessageHistoryView
        private String _groupName;
        public String GroupName
        {
            get { return _groupName; }
        }

        // Binding for the text message content
        private String _textMsg;
        public String TextMsg
        {
            get { return _textMsg; }
            set
            {
                _textMsg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TextMsg"));
            }
        }

        // bitmapImages for CanvasListButton
        public static BitmapImage canvasImage = new BitmapImage(new Uri("ms-appx:///Assets/compose-op7.png"));
        public static BitmapImage listImage = new BitmapImage(new Uri("ms-appx:///Assets/list-op2.png"));

        private BitmapImage _canvasListButton = canvasImage;
        public BitmapImage CanvasListButton
        {
            get
            {
                return _canvasListButton;
            }
            set
            {
                _canvasListButton = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CanvasListButton"));
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

        //Constructor used for testing code
        public MessageHistoryViewModel() { }

        //Constructor used for application code
        public MessageHistoryViewModel(GroupsContent group)
        {
            composeCommand = new DelegateCommand(toggleCanvasView);
            receiveCommand = new DelegateCommand(receive);
            addCommand = new DelegateCommand(addUsers);
            sendTextCommand = new DelegateCommand(sendText);

            model = new MessageHistoryModel();
            navService = NavigationService.getNavigationServiceInstance();

            LoadingIndicator = true;
            History = new ChatHistory(group.group.id);
            LoadingIndicator = false;

            this.group = group;

            // replace with group name when field is supplied
            if (group.group.Name != null)
            {
                this._groupName = group.group.Name;
            }
            else
            {
                this._groupName = "GROUP NAME";
            }

        }

        // Method binded to the Add button that adds a picture to the historyContainer
        public void addToHistory(MessageContent msg)
        {
            History.Add(msg);
        }

        /// <summary>
        /// Transitions the user into the canvas page
        /// </summary>
        private void compose()
        {
            //LeftFrameNavigator.DisplaySubFrame();
            //RightFrameNavigator.Navigate(typeof(CanvasPage), group);
        }

        /// <summary>
        /// receive images from the server
        /// </summary>
        public async void receive()
        {
            MessageApi msgApi = MessageApi.getInstance();
            UserApi userApi = UserApi.getInstance();
            IEnumerable<Message> messages = await msgApi.getGroupMessageData(group.group.id);
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            
            LoadingIndicator = true;

            if (messages != null && messages.Any())
            {
                foreach (var msg in messages)
                {
                    if (msg.id != null && !historyContainsMessage(msg.id))
                    {
                        var fstream = await msgApi.getMessageFile(group.group.id, msg.id);

                        if (fstream != null && fstream.Length > 0)
                        {
                            StorageFile targetFile = await storageFolder.CreateFileAsync(msg.id + ".png", CreationCollisionOption.ReplaceExisting);
                            using (Stream targetStream = await targetFile.OpenStreamForWriteAsync())
                            {
                                await fstream.CopyToAsync(targetStream);
                            }

                            Uri imageUri = new Uri(targetFile.Path, UriKind.Absolute);

                            User sender = await userApi.getUser(msg.SenderId);

                            MessageContent mc = new MessageContent(msg, sender, imageUri);
                            History.Insert(0, mc);
                        }
                        else
                        {
                            Debug.WriteLine("File with id " + msg.id + " not found");
                        }
                    }
                }
            }

            LoadingIndicator = false;
        }

        public async void sendText()
        {
            Message msgResponse = null;

            if (TextMsg != null && TextMsg != "")
            {
                LoadingIndicator = true;

                if (App.User == null)
                {
                    ContentDialog notLoggedInDialog = new ContentDialog()
                    {
                        Title = "Not logged in",
                        Content = "You are not logged in and cannot sync with the server",
                        PrimaryButtonText = "Ok"
                    };

                    await ContentDialogHelper.CreateContentDialogAsync(notLoggedInDialog, true);
                    return;
                }

                MessageApi api = MessageApi.getInstance();

                Message sentMsg = new Message
                {
                    SenderId = App.User.id,
                    GroupChatID = group.group.id,
                    Content = TextMsg
                };

                msgResponse = await api.sendMessageData(sentMsg);

                // If message was not sent to the server, initialize empty message with group id
                if (msgResponse == null)
                {
                    msgResponse = new PenscribCommon.Models.Message
                    {
                        id = "---",
                        GroupChatID = group.group.id,
                        Content = TextMsg

                    };
                    MessageContent badmsg = new MessageContent(msgResponse, App.User, null, MessageContent.errorImage);
                    History.Add(badmsg);
                    // Launch warning popup
                    ContentDialog notLoggedInDialog = new ContentDialog()
                    {
                        Title = "No Wifi",
                        Content = "Your message did not send. Please check your wifi signal.",
                        PrimaryButtonText = "Ok"
                    };
                    await ContentDialogHelper.CreateContentDialogAsync(notLoggedInDialog, true);
                }
                else
                {
                    MessageContent msg = new MessageContent(msgResponse, App.User, null);
                    History.Add(msg);
                }

                TextMsg = "";
                LoadingIndicator = false;
            }
        }

        /// <summary>
        /// Add users to the group
        /// Wrap method for addUsers(...)
        /// </summary>
        private async void addUsers()
        {
            string usersToAdd = await ContentDialogHelper.InputDialogAsync("Enter user emails", "Separate multiple emails with a space...");
            // Only try to add the user if the OK button was clicked
            addUsers(usersToAdd);
        }

        /// <summary>
        /// Add users to the group (helper for testability reasons)
        /// </summary>
        public virtual async void addUsers(string usersToAdd)
        {
            if (usersToAdd != "")
            {
                // separate input based on space
                char[] separators = { ' ', '\t', '\n' };
                String[] users = usersToAdd.Split(separators);

                bool newUsers = false;
                GroupChat updatedGroup = null;

                // Look at each potential user
                foreach (String user in users)
                {
                    // Add user to the group if a valid email address is provided and user is not already in group
                    // possibly perform a different check here? (check database for matching email?)
                    if (isValidEmail(user))
                    {
                        // Need to perform check to see if email is in db
                        User dbUser = await getUserFromEmail(user);
                        //User dbUser = theUserFromEmail;

                        // Display a dialog stating the user does not exist
                        if (dbUser == null)
                        {
                            displayContentDialogDispatch(contentDialogType.DNE, user);
                        }

                        // Display a dialog stating the user has already been added to the group
                        else if (group.group.GroupMembers.Contains(dbUser.id))
                        {
                            displayContentDialogDispatch(contentDialogType.RepeatMember, user);
                        }

                        else
                        {
                            group.group.GroupMembers.Add(dbUser.id);
                            //GroupChat updatedGroup = await GroupChatApi.getInstance().updateGroupChat(group);
                            updatedGroup = await updateGroupChat(group.group);

                            // Display a dialog stating the user is already in the group
                            if (updatedGroup == null)
                            {
                                displayContentDialogDispatch(contentDialogType.NoServer, user);
                                group.group.GroupMembers.Remove(dbUser.id);
                            }
                            else
                            {
                                displayContentDialogDispatch(contentDialogType.SuccessfulAdd, user);
                                newUsers = true;
                            }
                        }
                    }
                    // Display a dialog stating the input is not a valid email address form
                    else
                    {
                        displayContentDialogDispatch(contentDialogType.InvalidEmail, user);
                    }
                }

                // after all users have been checked, if at least one was successful then we need to update
                // the views
                if (newUsers)
                {
                    string members = await getGroupMemberNames(updatedGroup);
                    GroupsContent updatedContent = new GroupsContent(updatedGroup, members);
                    updatedContent.updateCanvasFrom(group);

                    // call needed to update the group lists in the GroupsViewModel
                    LeftFrameNavigator.Navigate(typeof(GroupsView), updatedContent);
                }
            }
        }

        protected virtual async Task<GroupChat> updateGroupChat(GroupChat group)
        {
            return await GroupChatApi.getInstance().updateGroupChat(group);
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
            switch(type)
            {
                case contentDialogType.DNE:
                    ContentDialog userInGroupDialog = new ContentDialog()
                    {
                        Title = "No User Added",
                        Content = user + " does not exist.",
                        PrimaryButtonText = "Ok"
                    };
                    await ContentDialogHelper.CreateContentDialogAsync(userInGroupDialog, true);
                    break;
                case contentDialogType.InvalidEmail:
                    ContentDialog invalidUserEmailDialog = new ContentDialog()
                    {
                        Title = "No User Added",
                        Content = user + " is not a valid email address form.",
                        PrimaryButtonText = "Ok"
                    };
                    await ContentDialogHelper.CreateContentDialogAsync(invalidUserEmailDialog, true);
                    break;
                case contentDialogType.RepeatMember:
                    ContentDialog repeatMemberDialog = new ContentDialog()
                    {
                        Title = "No User Added",
                        Content = user + " already in group.",
                        PrimaryButtonText = "Ok"
                    };
                    await ContentDialogHelper.CreateContentDialogAsync(repeatMemberDialog, true);
                    break;
                case contentDialogType.NoServer:
                    ContentDialog noServerDialog = new ContentDialog()
                    {
                        Title = "No User Added",
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
                string msgId = msgXml[0].InnerText;

                if (group.group.id == groupId)
                {
                    if (actionXml.Any() && actionXml[0].InnerText == "newAttachment")
                    {
                        History.addMsgFile(msgId);
                    }
                    else
                    {
                        History.retrieveNewMessages();
                    }
                }
            }
            
        }

        /// <summary>
        /// Checks to see if the collection of messages contains a message id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Boolean historyContainsMessage(string id)
        {
            foreach (MessageContent mc in History)
            {
                if (mc.msg != null && mc.msg.id.Length > 0 && mc.msg.id == id)
                {
                    return true;
                }
            }

            return false;
        }

        public async void messageClicked(ItemClickEventArgs e)
        {
            MessageContent clickedMessage = (MessageContent)e.ClickedItem;
            Uri path = clickedMessage.imageSource;

            if (path != null)
            {
                group.backgroundPath = path.ToString();

                if (!LeftFrameNavigator.isSubFrameVisible())
                {
                    LeftFrameNavigator.NavigateSubFrame(typeof(MessageHistoryView), this);
                }

                RightFrameNavigator.Navigate(typeof(CanvasPage), group);
            }
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

        private void toggleCanvasView()
        {
            if (LeftFrameNavigator.isSubFrameVisible())
            {
                // change the view
                LeftFrameNavigator.ClearSubFrame();
                RightFrameNavigator.Navigate(typeof(MessageHistoryView), this);
            }
            else
            {
                // change the view
                LeftFrameNavigator.NavigateSubFrame(typeof(MessageHistoryView), this);
                RightFrameNavigator.Navigate(typeof(CanvasPage), group);
            }
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
    }
}
