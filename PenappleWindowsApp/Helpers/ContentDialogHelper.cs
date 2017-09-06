using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace PenappleWindowsApp.Helpers
{
    /// <summary>
    /// http://stackoverflow.com/questions/33018346/only-a-single-contentdialog-can-be-open-at-any-time-error-while-opening-anoth
    /// </summary>
    public static class ContentDialogHelper
    {
        public static async void CreateContentDialog(ContentDialog Dialog, bool awaitPreviousDialog) { await CreateDialog(Dialog, awaitPreviousDialog); }
        public static async Task CreateContentDialogAsync(ContentDialog Dialog, bool awaitPreviousDialog) { await CreateDialog(Dialog, awaitPreviousDialog); }

        static async Task CreateDialog(ContentDialog Dialog, bool awaitPreviousDialog)
        {
            if (ActiveDialog != null)
            {
                if (awaitPreviousDialog)
                {
                    await DialogAwaiter.Task;
                    DialogAwaiter = new TaskCompletionSource<bool>();
                }
                else ActiveDialog.Hide();
            }
            ActiveDialog = Dialog;
            ActiveDialog.Closed += ActiveDialog_Closed;
            await ActiveDialog.ShowAsync();
            ActiveDialog.Closed -= ActiveDialog_Closed;
        }

        /// <summary>
        /// Create a dialog that takes text input from the user
        /// </summary>
        /// <param name="title">Title of the dialog</param>
        /// <param name="placeholder">Text placeholder for the textbox</param>
        /// <returns></returns>
        public static async Task<String> InputDialogAsync(String title, String placeholder)
        {
            TextBox inputTextBox = new TextBox();
            inputTextBox.AcceptsReturn = false;
            inputTextBox.Height = 32;
            inputTextBox.PlaceholderText = placeholder;

            ContentDialog dialog = new ContentDialog();
            dialog.Content = inputTextBox;
            dialog.Title = title;
            dialog.IsSecondaryButtonEnabled = true;
            dialog.PrimaryButtonText = "Ok";
            dialog.SecondaryButtonText = "Cancel";

            if (await dialog.ShowAsync() == ContentDialogResult.Primary)
            {
                return inputTextBox.Text;
            }
            else
            {
                return "";
            }
        }

        public static ContentDialog ActiveDialog;
        static TaskCompletionSource<bool> DialogAwaiter = new TaskCompletionSource<bool>();
        private static void ActiveDialog_Closed(ContentDialog sender, ContentDialogClosedEventArgs args) { DialogAwaiter.SetResult(true); }
    }
}
