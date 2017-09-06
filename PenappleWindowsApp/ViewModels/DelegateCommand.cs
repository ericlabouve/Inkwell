using System;
using System.Windows.Input;

namespace PenappleWindowsApp.ViewModels
{
    /* DelegateCommand
     * 
     * In c#, a "Delegate" defines a type that ENCAPSULATES A METHOD 
     * with a particular set of arguments and return type. Or in other
     * words, encapsulate a reference to a method inside an object.
     * 
     * It is important to have a Delegate wrapper class for our 
     * project so we that we can wrap functions inside ICommand 
     * objects and be able to pass them around.
     * 
     * Tutorial: https://msdn.microsoft.com/en-us/library/aa288459(v=vs.71).aspx
     * 
     * author: Eric LaBouve
     */
    public class DelegateCommand : ICommand
    {
        private readonly Action _action;

        public DelegateCommand(Action action)
        {
            _action = action;
        }

        public void Execute(object parameter)
        {
            _action();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged { add { } remove { } }
#pragma warning restore 67
    }
}