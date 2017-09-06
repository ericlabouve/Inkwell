using System;
using Windows.Security.Authentication.Web.Core;
using Windows.System;
using Windows.UI.ApplicationSettings;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Data.Json;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Http;
using PenappleWindowsApp.ViewModels;
using PenappleWindowsApp.NavigationServices;
using Windows.UI.ViewManagement;
using Windows.UI;

namespace PenappleWindowsApp.Views
{ 
    /* LoginPage
     * 
     * This class represents some of the hidden code behind LoginPageView.xaml
     * There should be no logic in this class, except for Page-Specific logic 
     * (unless you finds a way to abstract this logic).
     * 
     * @author Eric LaBouve
     * January 22nd, 2017
     */ 
    public sealed partial class LoginPage : Page
    {
        private LoginPageViewModel viewModel;
        public LoginPage()
        {
            this.InitializeComponent();
            
            // We have the option to inject a NavigationService if we need to in the future
            //
            //INavigationService navService = new NavigationService();
            //viewModel = new LoginPageViewModel(navService);

            viewModel = new LoginPageViewModel();
            // Bind View to ViewModel
            this.DataContext = viewModel;

            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            Color backgroundColor = Colors.Gainsboro;

            // This is the dark purple PenApple color
            //Color backgroundColor = Color.FromArgb(255, 90, 0, 180);

            titleBar.BackgroundColor = backgroundColor;
            titleBar.ButtonBackgroundColor = backgroundColor;
        }

    }
}
