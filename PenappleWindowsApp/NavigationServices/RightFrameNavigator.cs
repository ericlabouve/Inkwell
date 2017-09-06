using PenappleWindowsApp.Models;
using PenappleWindowsApp.ViewModels;
using PenappleWindowsApp.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace PenappleWindowsApp.NavigationServices
{
    class RightFrameNavigator
    {
        // instance of the right frame in the main window
        private static Frame frameInstance = null;

        // Reference to the specific context of the last page visited
        // made public for LeftFrameNavigator to change the specific MessageHistoryViewModel last visited
        private static MessageHistoryViewModel lastContext = null;

        public static Frame GetFrameInstance()
        {
            return frameInstance;
        }

        public static MessageHistoryViewModel GetLastContext()
        {
            return lastContext;
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

        public static void SetLastContext(MessageHistoryViewModel context)
        {
            lastContext = context;
        }

        public static void Navigate(Type sourcePage)
        {
            frameInstance.Navigate(sourcePage);
        }

        public static void Navigate(Type sourcePage, object parameter)
        {
            if (parameter is MessageHistoryViewModel)
            {
                MessageHistoryViewModel vm = (MessageHistoryViewModel)parameter;

                if (!vm.Equals(lastContext))
                {
                    lastContext = vm;
                }
            }

            frameInstance.Navigate(sourcePage, parameter);
        }
        
        // Should only be called when navigating to a previously visited MessageHistoryView
        public static void NavigateToLastMessageHistory()
        {
            frameInstance.Navigate(typeof(MessageHistoryView), lastContext);
        }
    }
}
