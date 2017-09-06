using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace PenappleWindowsApp.NavigationServices
{
    class ProfileNavigator
    {
        // instance of the frame in the main window
        private static Frame frameInstance = null;

        public static Frame GetFrameInstance()
        {
            return frameInstance;
        }

        public static void SetFrame(Frame frame)
        {
            if (frameInstance == null)
            {
                frameInstance = frame;
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

        public static bool isFrameVisible()
        {
            if (frameInstance.Content == null)
            {
                return false;
            }

            return true;
        }

        public static void ClearFrame()
        {
            frameInstance.Content = null;
        }
    }
}
