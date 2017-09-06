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

namespace PenappleWindowsApp.ViewModels
{
    /// <summary>
    /// MainPageViewModel
    /// 
    /// Container to hold the other screens of the application
    /// 
    /// </summary>
    class MainPageViewModel : INotifyPropertyChanged
    {
        /* Required event object from INotifyPropertyChanged
         * 
         * Use the following line of code to notify the view when 
         * a property that has been binded to has changed:
         * PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("VARIABLE NAME")); 
         */
        public event PropertyChangedEventHandler PropertyChanged;

        // bindings to MainPageView buttons
        public DelegateCommand homeCommand { get; private set; }
        public DelegateCommand switchToProfileCommand { get; private set; }

        // Reference to the Navigation Service
        private INavigationService navService;

        /* Constructor
         * Loads all DelegateCommand objects for button clicks.
         */
        public MainPageViewModel()
        {
            homeCommand = new DelegateCommand(resetScreen);
            switchToProfileCommand = new DelegateCommand(switchToProfile);
            navService = NavigationService.getNavigationServiceInstance();

            resetScreen();
        }

        /// <summary>
        /// Resets the screen, returns to the Home Screen of the app
        /// Left Frame: List of groups
        /// Right Frame: Empty screen
        /// </summary>
        public void resetScreen()
        {
            LeftFrameNavigator.Navigate(typeof(GroupsView), "groups");
            LeftFrameNavigator.ClearSubFrame();
            RightFrameNavigator.Navigate(typeof(MessageHistoryView));
        }

        /// <summary>
        /// Switch to the user's profile page
        /// </summary>
        public void switchToProfile()
        {
            navService.Navigate(typeof(ProfilePageView));
        }
    }
}
