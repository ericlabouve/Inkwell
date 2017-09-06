using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace PenappleWindowsApp.Models
{
    public class ImageContainer
    {
        public double xOffset { get; set; }
        public double yOffset { get; set; }
        public double newWidth { get; set; }
        public double newHeight { get; set; }
        public string imagePath { get; set; }
        public WriteableBitmap image { get; set; }
    }
}
