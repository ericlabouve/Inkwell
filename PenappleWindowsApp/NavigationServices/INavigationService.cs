using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenappleWindowsApp.NavigationServices
{
    /*
     * INavigationService Interface
     * 
     * Useful for future dependency injections.
     * Outlines the methods needed to navigate from and to pages.
     * 
     * source: http://stackoverflow.com/questions/26816264/page-navigation-using-mvvm-in-store-app
     * 
     * @author: Eric LaBouve
     */
    interface INavigationService
    {
        void Navigate(Type sourcePage);
        void Navigate(Type sourcePage, object parameter);
        void GoBack();
    }
}
