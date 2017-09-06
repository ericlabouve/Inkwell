using PenappleWindowsApp.NavigationServices;
using PenappleWindowsApp.ViewModels;
using PenappleWindowsApp.Views;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PenappleWindowsApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainPageViewModel viewModel;

        public MainPage()
        {
            this.InitializeComponent();

            // set the sidebar to GroupsSideBar
            sideBar.Navigate(typeof(GroupsSideBar));

            // set the Frame Navigator instances for navigating through the frames
            ProfileNavigator.SetFrame(profileFrame);
            LeftFrameNavigator.SetFrame(leftFrame);
            RightFrameNavigator.SetFrame(rightFrame);

            viewModel = new MainPageViewModel();
            this.DataContext = viewModel;
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            sideBar.Navigate(typeof(GroupsSideBar));

            ProfileNavigator.ClearFrame();
            LeftFrameNavigator.Navigate(typeof(GroupsView), "");
            LeftFrameNavigator.ClearSubFrame();
            RightFrameNavigator.Navigate(typeof(MessageHistoryView));
        }
    }
}
