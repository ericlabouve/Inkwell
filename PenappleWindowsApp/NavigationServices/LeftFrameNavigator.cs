using PenappleWindowsApp.ViewModels;
using PenappleWindowsApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace PenappleWindowsApp.NavigationServices
{
    class LeftFrameNavigator
    {
        // instance of the left frame in the main window
        private static Frame frameInstance = null;

        // reference to the sub-frame instance in the left frame
        // specifically found in the GroupsView
        private static Frame subFrame = null;

        // Reference to the specific context of the last page visited,
        // as of now, this will be the specific MessageHistoryViewModel
        //private static MessageHistoryViewModel lastContext = null;

        public static Boolean isSubFrameVisible()
        {
            if (subFrame.Content == null)
            {
                return false;
            }

            return true;
        }

        public static void SetFrame(Frame frame)
        {
            if (frameInstance == null)
            {
                frameInstance = frame;
            }
            else
            {
                throw new Exception("frameInstance already set. Can only be set once.");
            }
        }

        public static void SetSubFrame(Frame frame)
        {
            if (subFrame == null)
            {
                subFrame = frame;
            }
            else
            {
                throw new Exception("subFrame instance already set. Can only be set once.");
            }
        }

        public static void Navigate(Type sourcePage)
        {
            frameInstance.Navigate(sourcePage);
        }

        public static void Navigate(Type sourcePage, object parameter)
        {
            if (parameter is MessageHistoryViewModel)
            {
                RightFrameNavigator.SetLastContext((MessageHistoryViewModel)parameter);
            }

            frameInstance.Navigate(sourcePage, parameter);
        }

        // The SubFrame should only contain the MessageHistoryView when composing on a canvas,
        // otherwise the frame should be empty
        public static void NavigateSubFrame(Type sourcePage, object parameter)
        {
            subFrame.Navigate(sourcePage, parameter);
        }

        public static void ClearSubFrame()
        {
            subFrame.Content = null;
        }
    }
}
