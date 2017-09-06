using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using PenappleWindowsApp.NavigationServices;
using PenappleWindowsApp.Views;
using PenappleWindowsApp.Api;
using PenscribCommon.Models;
using Windows.Storage.Pickers;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage.Streams;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;

namespace PenappleWindowsApp.ViewModels
{
    public class ProfilePageViewModel : INotifyPropertyChanged
    {
        /* Required event object from INotifyPropertyChanged
         * 
         * Use the following line of code to notify the view when 
         * a property that has been binded to has changed:
         * PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("VARIABLE NAME")); 
         */
        public event PropertyChangedEventHandler PropertyChanged;

        // Button and Clickable Icon Actions
        public DelegateCommand backButtonCommand { get; private set; }
        public DelegateCommand logoutButtonCommand { get; private set; }
        public DelegateCommand iconCommand { get; private set; }

        // Reference to the Navigation Service
        INavigationService navService;

        // The letter that appears in the ink drop picture
        private string _profileIcon = ":(";
        public string profileIcon
        {
            get { return _profileIcon; }
            set
            {
                _profileIcon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("profileIcon"));
            }
        }

        // The first and last name of the user
        private string _userName = "No User Found";
        public string userName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("userName"));
            }
        }

        // The first and last name of the user
        private string _userEmail= "";
        public string userEmail
        {
            get { return _userEmail; }
            set
            {
                _userEmail = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("userEmail"));
            }
        }

        private BitmapImage defaultImage;
        private BitmapImage _userImage = new BitmapImage(new Uri("ms-appx:///Assets/ink-drop-hi-light-purple.png"));
        public BitmapImage userImage
        {
            get
            {
                return _userImage;
            }

            set
            {
                _userImage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("userImage"));
            }
        }

        /* Constructor
         */
        public ProfilePageViewModel()
        {
            //backButtonCommand = new DelegateCommand(backButtonClick);
            logoutButtonCommand = new DelegateCommand(logoutButtonClick);
            iconCommand = new DelegateCommand(changePicture);
            navService = NavigationService.getNavigationServiceInstance();
            defaultImage = _userImage;
        }

        /// <summary>
        /// Fill out the profile page with the current user's information
        /// </summary>
        public async Task fillOutProfileAsync()
        {
            if (App.User != null)
            {
                profileIcon = App.User.FirstName.Substring(0, 1);
                userName = App.User.Name;
                userEmail = App.User.Email;
                // Load a profile picture if set. Else the default will be loaded
                if (App.User.ProfilePicLocation != null && App.User.ProfilePicLocation.Length != 0)
                {
                    // set the image to the path from the server on the pc...

                    profileIcon = "";
                    userEmail = App.User.ProfilePicLocation;
                }
                else
                {
                    /*
                    Uri uri = new Uri("ms-appx:///Assets/ink-drop-hi.png");
                    IAsyncOperation<StorageFile> Ifile = StorageFile.GetFileFromApplicationUriAsync(uri);
                    StorageFile file = await Ifile.AsTask();
                    using (IRandomAccessStream stream = await file.OpenAsync(FileAccessMode.Read))
                    {
                        await userImage.SetSourceAsync(stream);
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("userImage"));
                    }
                    */
                }
            }
        }


        /// <summary>
        /// Allows users to search for an image on their device to choose as their profile picture
        /// </summary>
        public async void changePicture()
        {
            try
            { 
                FileOpenPicker picker = new FileOpenPicker();

                // Limit filter to only image files
                picker.FileTypeFilter.Add(".png");
                picker.FileTypeFilter.Add(".jpeg");
                picker.FileTypeFilter.Add(".jpg");
                StorageFile file = await picker.PickSingleFileAsync();

                using (IRandomAccessStream stream = await file.OpenAsync(FileAccessMode.Read))
                {
                    await userImage.SetSourceAsync(stream);
                }
                profileIcon = "";

                App.User.ProfilePicLocation = file.Path;

                // Notify the server of the change...
            }
            /* Needed this catch block for the possible exception by calling the function too rapidly 
               Reference: https://docs.microsoft.com/en-us/uwp/api/windows.ui.applicationsettings.accountssettingspane
            */
            catch (Exception exc)
            {
            }
        }

        public void logoutButtonClick()
        {
            // Not sure if this is correct but it allows the user to login as another user...
            App.User = null;
            navService.Navigate(typeof(LoginPage));
        }
    }
}
