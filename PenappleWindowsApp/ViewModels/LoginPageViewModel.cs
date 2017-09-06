using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using PenappleWindowsApp.Models;
using PenappleWindowsApp.ViewModels;
using Windows.UI.ApplicationSettings;
using Windows.Security.Authentication.Web.Core;
using System.Net.Http;
using Windows.Data.Json;
using PenscribCommon.Models;
using PenscribCommon.Helpers;
using PenappleWindowsApp.NavigationServices;
using PenappleWindowsApp;
using PenappleWindowsApp.Helpers;
using PenappleWindowsApp.Views;
using Windows.UI.Xaml.Controls;

namespace PenappleWindowsApp.ViewModels
{
    /* LoginPageViewModel
     * 
     * Contains all the business logic* for the LoginPageView.
     * 
     * *Business logic is the programming that manages communication 
     * between an end user interface and a database (LoginPageModel).
     * 
     * TODO: 
     * [x] Figure out why bindings are not working for buttons
     * 
     * author: Eric LaBouve
     * January 22, 2017
     */
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        /* Required event object from INotifyPropertyChanged
         * 
         * Use the following line of code to notify the view when 
         * a property that has been binded to has changed:
         * PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("VARIABLE NAME")); 
         */
        public event PropertyChangedEventHandler PropertyChanged;

        // Button actions
            /* UNCOMMENT THIS SECTION WHEN GOOGLE AND FACEBOOK LOGIN IS ADDED
            public DelegateCommand googleButtonCommand { get; private set; }
            public DelegateCommand facebookButtonCommand { get; private set; }
            */
        public DelegateCommand loginCommand { get; private set; }

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

        // Reference to the model
        private LoginPageModel model;

        // Reference to the Navigation Service
        INavigationService navService;

        /* Constructor
         * Loads all DelegateCommand objects for button clicks.
         */
        public LoginPageViewModel()
        {
            loginCommand = new DelegateCommand(LoginHelper.LoginOrRegisterAsync);
            LoadingIndicator = false;
            model = new LoginPageModel();
            navService = NavigationService.getNavigationServiceInstance();

            LoginHelper.LoginInitiated += (s, args) =>
            {
                LoadingIndicator = true;
            };

            LoginHelper.UserLoggedIn += async (s, user) =>
            {
                App.User = user;
                await App.notificationManager.InitNotificationsAsync(App.User.id);
                LoadingIndicator = false;
                navService.Navigate(typeof(MainPage));
            };

            LoginHelper.AuthError += async (s, errorMsg) =>
            {
                LoadingIndicator = false;
                ContentDialog loginFailDialog = new ContentDialog()
                {
                    Title = "Could not Log in :(",
                    Content = errorMsg,
                    PrimaryButtonText = "Ok"
                };

                await ContentDialogHelper.CreateContentDialogAsync(loginFailDialog, true);
            };
        }
    }
}
