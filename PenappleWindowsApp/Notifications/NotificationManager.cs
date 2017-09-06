using Microsoft.WindowsAzure.Messaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using Windows.Networking.PushNotifications;
using Windows.UI.Notifications;

namespace PenappleWindowsApp.Notifications
{
    public class NotificationManager
    {
        public PushNotificationChannel channel { get; set; }

        public void OnPushNotification(PushNotificationChannel sender, PushNotificationReceivedEventArgs e)
        {
            String notificationContent = String.Empty;

            Debug.WriteLine("NOTIFICATION: " + e);

            switch (e.NotificationType)
            {
                case PushNotificationType.Badge:

                    break;
                case PushNotificationType.Toast:
                    handleToastNotification(e.ToastNotification);
                    break;
                case PushNotificationType.Raw:
                    notificationContent = e.RawNotification.Content;
                    break;
            }
        }

        private void handleToastNotification(ToastNotification notification)
        {
            notification.SuppressPopup = true;
        }

        // https://docs.microsoft.com/en-us/azure/app-service-mobile/app-service-mobile-windows-store-dotnet-get-started-push
        public async Task InitNotificationsAsync(string userId)
        {
            channel = await PushNotificationChannelManager.CreatePushNotificationChannelForApplicationAsync();
            
            const string toastTemplate =
                "<toast>" +
                 "<visual>" +
                   "<binding template=\"ToastText02\">" +
                    "<text id=\"1\">$(title)</text>" +
                    "<text id=\"2\">$(content)</text>" +
                   "</binding>" +
                 "</visual>" +
                "</toast>";

            const string rawTemplate =
                "<root>" +
                "<Group>$(groupId)</Group>" +
                "<Message>$(messageId)</Message>" +
                "<Sender>$(senderId)</Sender>" +
                "<Action>$(action)</Action>" +
                "</root>";

            var hub = new NotificationHub("penscrib-notification-hub",
                "Endpoint=sb://penscrib-notifications.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=ZRR3SXi3eQoTSPa5kpMDzeRJrWooFXbIBn5Vgs8lIdw=");
            string[] tags = new string[] { "userId:" + userId };

            await hub.UnregisterAllAsync(channel.Uri);
 

            var toastresult = await hub.RegisterTemplateAsync(channel.Uri, toastTemplate, "toastNotification", tags);

            WnsHeaderCollection headers = new WnsHeaderCollection();
            headers.Add("X-WNS-Type", @"wns/raw");
            TemplateRegistration registration = new TemplateRegistration(channel.Uri, rawTemplate, "rawNotification", tags, headers);

            var rawresult = await hub.RegisterAsync(registration);

            channel.PushNotificationReceived += OnPushNotification;
        }
    }
}
