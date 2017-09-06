using PenscribCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace PenappleWindowsApp
{
    /// <summary>
    /// MessageContent
    /// 
    /// Class to represent the content of a message that 
    /// will be displayed in the message history screen
    /// 
    /// author: Jason Chin
    /// </summary>
    public class MessageContent
    {
        // Reference to the message
        public Message msg { get; }
        // Name and date information to display in the MessageHistoryView
        public String name_creationDate_String { get; private set; }
        // Message body text information to display in the MessageHistoryView
        public String message_String { get; private set; }
        // Reference to the user who sent the message
        public User sender { get; }
        // Reference to the image URI
        public Uri imageSource { get; set; }
        // Reference to the error message icon that shows when a message fails to send
        public Uri errorImageSource { get; set; }

        // Uri for errorImageSource
        public static Uri errorImage = new Uri("ms-appx:///Assets/ic_error_outline_black_24dp.png");

        /// <summary>
        /// MessageContent constructor
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="imageUri"></param>
        public MessageContent(Message msg, User sender, Uri imageUri)
        {
            this.msg = msg;
            this.sender = sender;
            imageSource = imageUri;
            errorImageSource = null;

            setInfo();  
        }

        /// <summary>
        /// MessageContent constructor
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="imageUri"></param>
        public MessageContent(Message msg, User sender, Uri imageUri, Uri errorImageUri)
        {
            this.msg = msg;
            this.sender = sender;
            imageSource = imageUri;
            errorImageSource = errorImageUri;

            setInfo();
        }

        public MessageContent(Uri imageUri)
        {
            this.msg = null;
            imageSource = imageUri;
            name_creationDate_String = "Unknown - " + getTimeStamp();
        }

        /// <summary>
        /// Sets the info field based on the status of the msg content
        /// </summary>
        private void setInfo()
        {
            StringBuilder sb = new StringBuilder();
            if (sender != null && sender.Name != null)
            {
                sb.Append(sender.Name);
            }
            else
            {
                sb.Append("Unknown");
            }

            sb.Append(" - ");

            if (msg.CreationDate != null)
            {
                sb.Append(msg.CreationDate.ToLocalTime().ToString("MM/dd/yy hh:mm"));
            }
            else
            {
                sb.Append("NA");
            }

            name_creationDate_String = sb.ToString();
            

            // Display text messages in the info field
            if (msg.Content != null)
            {
                //name_creationDate_String +=  Environment.NewLine + msg.Content;
                message_String = msg.Content;
            }
        }

        /// <summary>
        /// Return a timestamp of the current time
        /// </summary>
        /// <returns></returns>
        private String getTimeStamp()
        {
            return DateTime.Now.ToString("MM/dd hh:mm");
        }

        public override bool Equals(object obj)
        {
            var mc = obj as MessageContent;

            if (mc == null)
            {
                return false;
            }

            return this.msg.id.Length > 0 && this.msg.id == mc.msg.id;
        }

    }
}
