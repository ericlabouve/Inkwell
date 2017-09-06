using System;
using System.Threading.Tasks;
using PenscribCommon.Models;
using System.Net.Http;
using Microsoft.Identity.Client;
using PenappleWindowsApp.Helpers;
using PenappleWindowsApp;
using System.Security.Claims;
using Windows.UI.Xaml.Controls;

namespace PenscribCommon.Helpers
{
    // https://docs.microsoft.com/en-us/azure/active-directory-b2c/active-directory-b2c-devquickstarts-native-dotnet

    public static class LoginHelper
    {
        public const string objectIdElement = "http://schemas.microsoft.com/identity/claims/objectidentifier";

        /// <summary>
        /// Logs in or registers a user whose email has not already been registered.
        /// If successful, calls the UserLoggedIn event handler and sets the user in ApiHelper
        /// </summary>
        /// <param name="info">Information needed by the api to log a user in</param>
        /// <returns></returns>
        public static async void LoginOrRegisterAsync()
        {
            AuthenticationResult result = null;

            try
            {
                PublicClientApplication pca = App.AuthClient;
                result = await pca.AcquireTokenAsync(Globals.DefaultScopes);

                ApiHelper.setToken(result.AccessToken);

                LoginInitiated?.Invoke(DateTime.Now, null);

                Models.User user = await ApiHelper.GetAsync<Models.User>("User");

                if (user == null || user.Email == null)
                {
                    user = await ApiHelper.PostAsync<Models.User>("User");
                }

                

                if (user != null && !String.IsNullOrWhiteSpace(user.Email))
                {
                    
                    UserLoggedIn?.Invoke(DateTime.Now, user);
                }
                else
                {
                    AuthError?.Invoke(DateTime.Now, "No connection to server.");
                }
            }
            catch (MsalException ex)
            {
                if (ex.ErrorCode != "authentication_canceled")
                {
                    string message = ex.Message;
                    if (ex.InnerException != null)
                    {
                        message += "\nInner Exception: " + ex.InnerException.Message;
                    }

                    AuthError?.Invoke(DateTime.Now, message);
                }
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                // Launch warning popup
                ContentDialog notLoggedInDialog = new ContentDialog()
                {
                    Title = "Could not login",
                    Content = "Please check your wifi signal.",
                    PrimaryButtonText = "Ok"
                };
                await ContentDialogHelper.CreateContentDialogAsync(notLoggedInDialog, true);
            }
        }

        // Use this eventhandler to create a callback for when login has been initiated
        public static event EventHandler LoginInitiated;

        // Use this eventhandler to create a callback for when a user successfully logs in
        public static event EventHandler<Models.User> UserLoggedIn;

        // Use this eventhandler to create a callback for when auser fails to log in
        public static event EventHandler<string> AuthError;
    }
} 
