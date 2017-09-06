using PenappleWindowsApp.ViewModels;
using PenappleWindowsApp.NavigationServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Networking.PushNotifications;
using Universal.UI.Xaml.Controls;
using PenscribCommon.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PenappleWindowsApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GroupsView : Page
    {
        private GroupsViewModel viewModel;

        // set when the GroupsList is interacted with
        private GroupsContent selectedGroup;

        public GroupsView()
        {
            this.InitializeComponent();

            LeftFrameNavigator.SetSubFrame(contentFrame);

            selectedGroup = null;
            viewModel = new GroupsViewModel();
            this.DataContext = viewModel;
            this.NavigationCacheMode = NavigationCacheMode.Required;
            App.notificationManager.channel.PushNotificationReceived += OnPushNotification;
        }

        private void GroupsBox_ItemClick(object sender, ItemClickEventArgs e)
        {
            viewModel.groupClicked(sender, e);
        }

        private void GroupsBox_ItemSwipe(object sender, Universal.UI.Xaml.Controls.ItemSwipeEventArgs e)
        {
            viewModel.itemSwiped(sender, e);
        }

        private void GroupsBox_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            selectedGroup = ((FrameworkElement)e.OriginalSource).DataContext as GroupsContent;

            ListView lv = (ListView)sender;
            GroupOptionsFlyout.ShowAt(lv, e.GetPosition(lv));
        }

        private async void Rename_Clicked(object sender, RoutedEventArgs e)
        {
            await viewModel.changeGroupNameAsync(selectedGroup);
        }

        private void Delete_Clicked(object sender, RoutedEventArgs e)
        {
            viewModel.deleteGroup(selectedGroup);
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            // updates the GroupsView when a group is changed (when a user is added to the group)
            if (e.Parameter is GroupsContent)
            {
                GroupsContent updatedContent = (GroupsContent)e.Parameter;

                // Need to first remove the GroupsContent, then display the new group content
                if (viewModel.GroupsList.Contains(updatedContent))
                {
                    viewModel.GroupsList.Remove(updatedContent);
                }
                
                viewModel.displayNewGroup(updatedContent);
            }
            else if (e.Parameter is string)
            {
                string selectedList = (string)e.Parameter;

                switch (selectedList)
                {
                    case "groups":
                        viewModel.switchToGroups();
                        break;
                    case "journal":
                        viewModel.switchToJournal();
                        break;
                    default:
                        viewModel.resetGroups();
                        viewModel.switchToGroups();
                        break;
                }
            }
        }

        private async void OnPushNotification(PushNotificationChannel sender, PushNotificationReceivedEventArgs e)
        {
            if (e.NotificationType == PushNotificationType.Raw && viewModel != null)
            {

                await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
                () =>
                {
                    viewModel.handleRawNotification(e.RawNotification);
                }
                );

            }
        }

        private int getGroupsContentIndex(string id)
        {
            int counter = 0;
            foreach (GroupsContent gc in viewModel.GroupsList)
            {
                if (gc.group.id == id)
                {
                    return counter;
                }
                counter++;
            }

            return -1;
        }
    }
}
