using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PenappleWindowsApp
{
    public class MessageListTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SentMessageTemplate { get; set; }
        public DataTemplate ReceivedMessageTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item">The item to return a template for.</param>
        /// <returns></returns>
        protected override DataTemplate SelectTemplateCore(object item)
        {
            MessageContent mc = item as MessageContent;
            if (App.User.id == mc.sender.id)
                return SentMessageTemplate;
            else
                return ReceivedMessageTemplate;
            
        }
    }
}
