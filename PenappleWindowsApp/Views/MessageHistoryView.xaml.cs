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
using PenappleWindowsApp.ViewModels;
using PenappleWindowsApp.NavigationServices;
using Windows.UI.Xaml.Media.Imaging;
using PenappleWindowsApp.Helpers;
using Windows.System;
using System.Windows.Input;
using Windows.Networking.PushNotifications;

namespace PenappleWindowsApp.Views
{
    /// <summary>
    /// MessageHistoryView.xaml.cs 
    /// Contains a reference to the ViewModel
    /// Maintains the state of the ViewModel
    /// 
    /// By: Eric LaBouve
    /// </summary>
    public sealed partial class MessageHistoryView : Page
    {
        //private NavigationHelper navigationHelper;
        private MessageHistoryViewModel viewModel;

        // set when the user right clicks a message
        private MessageContent selectedMessage;

        public MessageHistoryView()
        {
            this.InitializeComponent();
            viewModel = null;
            selectedMessage = null;

            App.notificationManager.channel.PushNotificationReceived += OnPushNotification;

            // Preserves the state of the page even after user has navigated away
            // Appreciate this line of code! It took me 2 hours find a concise
            // solution to saving the state of a page for ASP.NET UWP Windows 10!
            this.NavigationCacheMode = NavigationCacheMode.Required;

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

        // EventHandler to determine when certain keys are processed
        private void OnKeyDownHandler(object sender, KeyRoutedEventArgs e)
        {
            if (viewModel != null)
            {
                if (e.Key.Equals(VirtualKey.Enter))
                {
                    e.Handled = true;
                    viewModel.sendText();
                }
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
            if (e.Parameter == null)
            {
                MessageHistoryGrid.Visibility = Visibility.Collapsed;
            }

            if (e.Parameter != null)
            {
                if (MessageHistoryGrid.Visibility == Visibility.Collapsed)
                {
                    MessageHistoryGrid.Visibility = Visibility.Visible;
                }

                if (e.Parameter is MessageContent)
                {
                    MessageContent msg = (MessageContent)e.Parameter;
                    viewModel.addToHistory(msg);

                }
                else if (e.Parameter is MessageHistoryViewModel)
                {
                    MessageHistoryViewModel selectedViewModel = (MessageHistoryViewModel)e.Parameter;
                    viewModel = selectedViewModel;

                    if (LeftFrameNavigator.isSubFrameVisible())
                    {
                        viewModel.CanvasListButton = MessageHistoryViewModel.listImage;
                    }
                    else
                    {
                        viewModel.CanvasListButton = MessageHistoryViewModel.canvasImage;
                    }

                    this.DataContext = viewModel;
                }
            }
        }

        // temp function. needs to conform to mvvm
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationServices.NavigationService.getNavigationServiceInstance().Navigate(typeof(GroupsView));
        }

        private void messageClicked(object sender, ItemClickEventArgs e)
        {
            viewModel.messageClicked(e);
        }

        private void HistoryBox_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            // grab the MessageContent being right clicked
            selectedMessage = ((FrameworkElement)e.OriginalSource).DataContext as MessageContent;

            ListView lv = (ListView)sender;
            MessageOptionsFlyout.ShowAt(lv, e.GetPosition(lv));
        }

        private void UseText_Click(object sender, RoutedEventArgs e)
        {
            string content = selectedMessage.msg.Content;

            // append the text content of a right clicked message to the textbox
            if (content != null && content != "")
            {
                TextMsgBox.Text += content;
            }
        }

        private void Tag_Click(object sender, RoutedEventArgs e)
        {
            TextMsgBox.Text += "@" + selectedMessage.msg.Sender.FirstName + ": ";
        }

        private void Resend_Click(object sender, RoutedEventArgs e)
        {
            // TODO 
        }
    }
}
