using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PenappleWindowsApp.NavigationServices
{
    /* NavigationService
     * 
     * Controls how the user switches between screens.
     * Class is a singleton design pattern
     * 
     * source: http://stackoverflow.com/questions/26816264/page-navigation-using-mvvm-in-store-app
     * author: Eric LaBouve
     */
    class NavigationService : INavigationService
    {
        public static NavigationService instance = null;
        
        public static INavigationService getNavigationServiceInstance()
        {
            if (instance == null)
            {
                instance = new NavigationService();
            }
            return instance;
        }

        /* Navigate the user to page |sourcePage|
         * @param sourcePage - The page to naviage to.
         */
        public void Navigate(Type sourcePage)
        {
            var frame = (Frame)Window.Current.Content;
            frame.Navigate(sourcePage);
        }

        /* Navigate the user to page |sourcePage|
         * @param sourcePage - The page to naviage to.
         * @param parameter - Any additonal info that will be passed
         *      from the current page to the |sourcePage|
         */
        public void Navigate(Type sourcePage, object parameter)
        {
            var frame = (Frame)Window.Current.Content;
            frame.Navigate(sourcePage, parameter);
        }

        /* Returns to the page last visited by this NavigationService.
         */
        public void GoBack()
        {
            var frame = (Frame)Window.Current.Content;
            frame.GoBack();
        }
    }
}
