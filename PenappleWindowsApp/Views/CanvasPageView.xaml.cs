using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using PenappleWindowsApp.ViewModels;

using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Core;
using PenscribCommon.Models;
using PenappleWindowsApp.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PenappleWindowsApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CanvasPage : Page
    {
        private CanvasPageViewModel viewModel;

        public CanvasPage()
        {
            this.InitializeComponent();
            viewModel = null;
           
            this.DataContext = viewModel;
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            CanvasElements canvasElements = new CanvasElements
                (canvas, toolbar, commandBar, openHamburger, closeHamburger);

            if (e.Parameter is GroupsContent)
            {
                GroupsContent content = (GroupsContent)e.Parameter;

                // load group's stroke container
                canvas.InkPresenter.StrokeContainer = content.strokes;

                this.viewModel = new CanvasPageViewModel(canvasElements, content);
                this.DataContext = viewModel;

                // set the background image if there is one
                if (content.backgroundPath != null)
                {
                    viewModel.setBackgroundImage(content.backgroundPath);
                }
                else if (content.imageContainer != null)
                {
                    ImageContainer ic = content.imageContainer;

                    viewModel.imageFilePath = ic.imagePath;
                    viewModel.ImageBitmap = ic.image;

                    viewModel.xOffset = ic.xOffset;
                    viewModel.yOffset = ic.yOffset;
                    viewModel.newWidth = ic.newWidth;
                    viewModel.newHeight = ic.newHeight;
                }
            }
        }
    }
}
