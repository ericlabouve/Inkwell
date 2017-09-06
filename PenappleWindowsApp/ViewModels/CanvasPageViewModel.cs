using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using PenappleWindowsApp.Models;
using PenappleWindowsApp.NavigationServices;
using PenappleWindowsApp.Views;
using Windows.UI.Xaml.Controls;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml;
using Microsoft.Graphics.Canvas;
using Windows.UI;
using PenappleWindowsApp.Api;
using System.IO;
using PenscribCommon.Models;
using PenappleWindowsApp.Helpers;
using Windows.Storage.FileProperties;
using Windows.Graphics.Imaging;
using System.Runtime.InteropServices.WindowsRuntime;

namespace PenappleWindowsApp.ViewModels
{
    /* LoginPageViewModel
     * 
     * Contains all the business logic for the CanvasPageView.
     * 
     * Business logic is the programming that manages communication 
     * between an end user interface and a database (CanvasPageModel).
     * 
     * author: Minjie Fang
     */
    public class CanvasPageViewModel : INotifyPropertyChanged
    {
        private const int BITMAP_DPI_RESOLUTION = 96;

        public event PropertyChangedEventHandler PropertyChanged;

        //Button Actions
        public DelegateCommand sendCommand { get; private set; }
        public DelegateCommand clearButtonCommand { get; private set; }
        public DelegateCommand imageButtonCommand { get; private set; }
        public DelegateCommand showToolbarButtonCommand { get; private set; }

        INavigationService navService;

        private CanvasElements canvasElements;
        private CanvasPageModel model;
        private WriteableBitmap sourceImage;
        private StorageFile copiedFile;
        public string imageFilePath;
        public double newHeight, newWidth, xOffset, yOffset;
        private double height, width, canvasSize;

        private string _backgroundImagePath;
        public string BackgroundImagePath
        {
            get { return _backgroundImagePath; }
            set
            {
                _backgroundImagePath = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BackgroundImagePath"));
            }
        }

        private WriteableBitmap _imageBitmap;
        public WriteableBitmap ImageBitmap
        {
            get { return _imageBitmap; }
            set
            {
                _imageBitmap = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ImageBitmap"));
            }
        }

        // Progress ring loading for long running tasks
        private bool _loadingIndicator;
        public bool LoadingIndicator
        {
            get { return _loadingIndicator; }
            set
            {
                if (_loadingIndicator != value)
                {
                    _loadingIndicator = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LoadingIndicator"));
                }
            }
        }


        private GroupsContent group;

        public CanvasPageViewModel(CanvasElements elements, GroupsContent group)
        {
            sendCommand = new DelegateCommand(send);
            clearButtonCommand = new DelegateCommand(CanvasClear);
            imageButtonCommand = new DelegateCommand(loadImageAsync);
            showToolbarButtonCommand = new DelegateCommand(ShowToolbar);

            model = new CanvasPageModel();
            navService = NavigationService.getNavigationServiceInstance();
            
            canvasElements = elements;

            canvasElements.canvas.InkPresenter.InputDeviceTypes =
                Windows.UI.Core.CoreInputDeviceTypes.Mouse |
                Windows.UI.Core.CoreInputDeviceTypes.Pen |
                Windows.UI.Core.CoreInputDeviceTypes.Touch;

            this.group = group;
            canvasSize = 1080;
        }

        private string formatBackgroundFilePath(string path)
        {
            //Path includes file:/// at the beginning which cannot be used to load files async
            //these characters must be removed to properly load the desired file
            return path.Substring(8);
        }

        private async void send()
        {
            if (App.User == null)
            {
                ContentDialog notLoggedInDialog = new ContentDialog()
                {
                    Title = "Not logged in",
                    Content = "You are not logged in and cannot sync with the server",
                    PrimaryButtonText = "Ok"
                };

                await ContentDialogHelper.CreateContentDialogAsync(notLoggedInDialog, true);
                return;
            }

            try
            {
                LoadingIndicator = true;
                // Create a file for storing the drawing
                string filename = DateTime.Now.ToString("yyyy-MM-ddTHHmmssffff") + ".png";
                StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
                StorageFile targetFile = await storageFolder.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
                System.Diagnostics.Debug.WriteLine("Saving message as " + targetFile.Path);

                // Used to pass message back to MessagesHistory
                BitmapImage bitmapImage = new BitmapImage();

                Message msgResponse = null;

                if (targetFile != null)
                {
                    CanvasDevice device = CanvasDevice.GetSharedDevice();
                    CanvasRenderTarget renderTarget = new CanvasRenderTarget(device, (int)canvasElements.canvas.ActualWidth,
                        (int)canvasElements.canvas.ActualHeight, BITMAP_DPI_RESOLUTION);

                    using (var drawSession = renderTarget.CreateDrawingSession())
                    {
                        // Set the background color of the image
                        drawSession.Clear(Colors.White);
                        //Transfer the background image to the bitmap image if there is a background image
                        if (BackgroundImagePath != null && BackgroundImagePath.Length > 0)
                        {
                            CanvasBitmap background = await CanvasBitmap.LoadAsync(device,
                                                      formatBackgroundFilePath(BackgroundImagePath));
                            drawSession.DrawImage(background);
                        }
                        if (imageFilePath != null)
                        {
                            System.Diagnostics.Debug.WriteLine(" SENDING IMAGE FILE ");
                            CanvasBitmap image = await CanvasBitmap.LoadAsync(device, imageFilePath);
                            
                            drawSession.DrawImage(image, new Windows.Foundation.Rect(xOffset, yOffset, newWidth, newHeight));
                        }
                        // Transfer all the strokes to the bitmap image
                        drawSession.DrawInk(canvasElements.canvas.InkPresenter.StrokeContainer.GetStrokes());
                    }

                    using (IRandomAccessStream stream = await targetFile.OpenAsync(FileAccessMode.ReadWrite))
                    {
                        await renderTarget.SaveAsync(stream, CanvasBitmapFileFormat.Png, 1f);
                    }


                    MessageApi api = MessageApi.getInstance();

                    Message sentMsg = new Message
                    {
                        SenderId = App.User.id,
                        GroupChatID = group.group.id
                    };

                    msgResponse = await api.sendMessageData(sentMsg);

                    if (msgResponse != null)
                    {
                        using (Stream stream = await targetFile.OpenStreamForReadAsync())
                        {
                            // Send the image file. If successful rename the local file to the id
                            if (await api.sendMessageFile(stream, msgResponse.id))
                            {
                                // rename the locally saved file to incorporate the server generated id
                                await targetFile.RenameAsync(msgResponse.id + ".png");
                            }
                            else
                            {
                                System.Diagnostics.Debug.WriteLine("File failed to send");
                                // Launch warning popup
                                ContentDialog notLoggedInDialog = new ContentDialog()
                                {
                                    Title = "File failed to send",
                                    Content = "Your message did not send. Please check your wifi signal.",
                                    PrimaryButtonText = "Ok"
                                };
                                await ContentDialogHelper.CreateContentDialogAsync(notLoggedInDialog, true);
                            }

                        }
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Message failed to send");
                        // Launch warning popup
                        ContentDialog notLoggedInDialog = new ContentDialog()
                        {
                            Title = "File failed to send",
                            Content = "Your message did not send. Please check your wifi signal.",
                            PrimaryButtonText = "Ok"
                        };
                        await ContentDialogHelper.CreateContentDialogAsync(notLoggedInDialog, true);
                    }


                }
                MessageContent msg = null;
                Uri imageUri = new Uri(targetFile.Path, UriKind.Absolute);

                // If message was not sent to the server, initialize empty message with group id
                if (msgResponse == null)
                {
                    msgResponse = new PenscribCommon.Models.Message
                    {
                        id = "---",
                        GroupChatID = group.group.id,
                    };
                    msg = new MessageContent(msgResponse, App.User, imageUri, MessageContent.errorImage);
                }
                else
                {
                    msg = new MessageContent(msgResponse, App.User, imageUri);
                }

                //Uri imageUri = new Uri(targetFile.Path, UriKind.Absolute);
                //MessageContent msg = new MessageContent(msgResponse, App.User, imageUri);
                
                LeftFrameNavigator.NavigateSubFrame(typeof(MessageHistoryView), msg);

                // Clear the canvas
                canvasElements.canvas.InkPresenter.StrokeContainer.Clear();

                // Clear any background image
                BackgroundImagePath = null;
                group.backgroundPath = null;

                // Clear any loaded image
                imageFilePath = null;
                sourceImage = null;
                ImageBitmap = sourceImage;
                group.imageContainer = null;
            }
            finally
            {
                LoadingIndicator = false;
            }      
        }

        private void CanvasClear()
        {
            //canvasElements.canvas.InkPresenter.StrokeContainer.Clear();
            BackgroundImagePath = null;
            imageFilePath = null;
            sourceImage = null;
            ImageBitmap = sourceImage;
            
            group.backgroundPath = null;
            group.imageContainer = null;
        }

        public void clearStrokes()
        {
            canvasElements.canvas.InkPresenter.StrokeContainer.Clear();
        }

        private async void loadImageAsync()
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");

            StorageFile imageFile = await picker.PickSingleFileAsync();
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile storageFile = null;
            sourceImage = null;

            if (imageFile != null)
            { 
                ImageProperties properties = await imageFile.Properties.GetImagePropertiesAsync();
                height = (double)properties.Height;
                width = (double)properties.Width;
                double ratio;

                if (height < width)
                {
                    ratio = canvasSize / width;
                }
                else
                {
                    ratio = canvasSize / height;
                }
                newHeight = height * ratio;
                newWidth = width * ratio;
                xOffset = (canvasSize - newWidth) / 2;
                yOffset = (canvasSize - newHeight) / 2;

                try
                {
                    storageFile = await storageFolder.GetFileAsync(imageFile.Name);
                }
                catch (Exception e) { }
                if (storageFile == null)
                {
                    copiedFile = await imageFile.CopyAsync(storageFolder);
                }
                else
                {
                    copiedFile = storageFile;
                }
                sourceImage = await StorageFileToWriteableBitmap(imageFile);

                imageFilePath = copiedFile.Path;
                imageFilePath = imageFilePath.Replace("\\", "/");
                ImageBitmap = sourceImage;

                // set any previous background path to null
                BackgroundImagePath = null;
                group.backgroundPath = null;

                // set the GroupContent to hold this image
                ImageContainer ic = new ImageContainer
                {
                    xOffset = xOffset,
                    yOffset = yOffset,
                    newWidth = newWidth,
                    newHeight = newHeight,
                    imagePath = imageFilePath,
                    image = ImageBitmap,
                };
                group.imageContainer = ic;
            }
        }

        internal async Task<WriteableBitmap> StorageFileToWriteableBitmap(StorageFile file)
        {
            if (file == null)
                return null;
            WriteableBitmap bmp;
            using (IRandomAccessStream stream = await file.OpenAsync(FileAccessMode.Read))
            {
                BitmapDecoder decoder = await BitmapDecoder.CreateAsync(stream);
                bmp = new WriteableBitmap((int)decoder.PixelWidth, (int)decoder.PixelHeight);

                bmp.SetSource(stream);
            }
            if (width > canvasSize || height > canvasSize)
            {
                bmp = await ResizeByDecoderAsync(bmp, (int)newWidth, (int)newHeight, true);
            }
            return bmp;
        }

        internal async Task<WriteableBitmap> ResizeByDecoderAsync(WriteableBitmap image, int new_Width, int new_Height, bool IsProportion)
        {
            int lW = image.PixelWidth;
            int lH = image.PixelHeight;

            if (new_Width != 0 && new_Height != 0)
            {
                double nWidthFactor = (double)lW / (double)new_Width;
                double nHeightFactor = (double)lH / (double)new_Height;

                if (nWidthFactor != nHeightFactor && !IsProportion)
                {
                    if (Math.Abs(nWidthFactor - 1.0f) > Math.Abs(nHeightFactor - 1.0f))
                    {
                        new_Width = (int)((double)lW / nHeightFactor);
                        nWidthFactor = nHeightFactor;
                    }
                    else
                    {
                        new_Height = (int)((double)lH / nWidthFactor);
                        nHeightFactor = nWidthFactor;
                    }
                }
            }

            // Get the pixel buffer of the writable bitmap in bytes
            Stream stream = image.PixelBuffer.AsStream();
            byte[] pixels = new byte[(uint)stream.Length];
            await stream.ReadAsync(pixels, 0, pixels.Length);
            //Encoding the data of the PixelBuffer we have from the writable bitmap
            var inMemoryRandomStream = new InMemoryRandomAccessStream();
            var encoder = await BitmapEncoder.CreateAsync(BitmapEncoder.PngEncoderId, inMemoryRandomStream);
            encoder.SetPixelData(BitmapPixelFormat.Bgra8, BitmapAlphaMode.Straight, (uint)image.PixelWidth, (uint)image.PixelHeight, 96, 96, pixels);
            await encoder.FlushAsync();
            // At this point we have an encoded image in inMemoryRandomStream
            // We apply the transform and decode
            var transform = new BitmapTransform
            {
                ScaledWidth = (uint)new_Width,
                ScaledHeight = (uint)new_Height,
                InterpolationMode = BitmapInterpolationMode.Fant
            };
            inMemoryRandomStream.Seek(0);
            var decoder = await BitmapDecoder.CreateAsync(inMemoryRandomStream);
            var pixelData = await decoder.GetPixelDataAsync(
                            BitmapPixelFormat.Bgra8,
                            BitmapAlphaMode.Straight,
                            transform,
                            ExifOrientationMode.IgnoreExifOrientation,
                            ColorManagementMode.DoNotColorManage);
            // An array containing the decoded image data
            var sourceDecodedPixels = pixelData.DetachPixelData();
            // Approach 1 : Encoding the image buffer again:
            // Encoding data
            var inMemoryRandomStream2 = new InMemoryRandomAccessStream();
            var encoder2 = await BitmapEncoder.CreateAsync(BitmapEncoder.PngEncoderId, inMemoryRandomStream2);
            encoder2.SetPixelData(BitmapPixelFormat.Bgra8, BitmapAlphaMode.Straight, (uint)new_Width, (uint)new_Height, 96, 96, sourceDecodedPixels);
            await encoder2.FlushAsync();
            inMemoryRandomStream2.Seek(0);
            // finally the resized writablebitmap
            var bitmap = new WriteableBitmap((int)new_Width, (int)new_Height);
            await bitmap.SetSourceAsync(inMemoryRandomStream2);
            return bitmap;
        }

        private void ShowToolbar()
        {
            if (canvasElements.toolbar.Visibility.Equals(Visibility.Collapsed))
            {
                canvasElements.toolbar.Visibility = Visibility.Visible;
                canvasElements.commandBar.Visibility = Visibility.Visible;
                canvasElements.closeHamburger.Visibility = Visibility.Visible;
                canvasElements.openHamburger.Visibility = Visibility.Collapsed;
            }
            else
            {
                canvasElements.toolbar.Visibility = Visibility.Collapsed;
                canvasElements.commandBar.Visibility = Visibility.Collapsed;
                canvasElements.closeHamburger.Visibility = Visibility.Collapsed;
                canvasElements.openHamburger.Visibility = Visibility.Visible;
            }
        }

        internal void setBackgroundImage(string path)
        {
            if (path != null && path.Length > 0)
            {
                BackgroundImagePath = path;
            }
        }
    }

    public struct CanvasElements
    {
        internal InkCanvas canvas;
        internal InkToolbar toolbar;
        internal CommandBar commandBar;
        internal Button openHamburger;
        internal Button closeHamburger;

        public CanvasElements(InkCanvas can, InkToolbar tools,
            CommandBar com, Button open, Button close)
        {
            canvas = can;
            toolbar = tools;
            commandBar = com;
            openHamburger = open;
            closeHamburger = close;
        }
    }
}
