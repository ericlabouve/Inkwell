using PenappleWindowsApp.Api;
using PenscribCommon.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Storage;
using Windows.UI.Xaml.Data;

namespace PenappleWindowsApp
{
    public class ChatHistory : ObservableCollection<MessageContent>, ISupportIncrementalLoading
    {
        public string groupId { get; }
        public List<Message> groupMessages;

        private bool _busy = false;
        private MessageApi msgApi;

        public ChatHistory(string groupId)
        {
            this.groupId = groupId;
            groupMessages = new List<Message>();
            msgApi = MessageApi.getInstance();
        }

        public IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync(uint count)
        {
            if (_busy)
            {
                new LoadMoreItemsResult { Count = 0 };
            }

            _busy = true;

            return AsyncInfo.Run((c) => LoadMoreItemsAsync(c, count));
        }

        async Task<LoadMoreItemsResult> LoadMoreItemsAsync(CancellationToken c, uint count)
        {
            try
            {
                Debug.WriteLine("Trying to load: " + count + " more messages");

                long toTime;
                if (groupMessages.Any())
                {
                    toTime = (long)groupMessages.Last().CreationDate.Subtract(
                        new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds - 1;
                }
                else
                {
                    toTime = (long)DateTime.UtcNow.Subtract(
                        new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
                }

                var newMsgs = await msgApi.getGroupMessageDataBefore(groupId, toTime, (int)count);

                StorageFolder storageFolder = ApplicationData.Current.LocalFolder;

                foreach (Message msg in newMsgs)
                {
                    MessageContent mc;

                    if (msg.GraphicsLocation == null)
                    {
                        mc = new MessageContent(msg, msg.Sender, null);
                    }
                    else
                    {
                        var fstream = await msgApi.getMessageFile(groupId, msg.id);

                        if (fstream != null && fstream.Length > 0)
                        {
                            StorageFile targetFile = await storageFolder.CreateFileAsync(msg.id + ".png", CreationCollisionOption.ReplaceExisting);
                            using (Stream targetStream = await targetFile.OpenStreamForWriteAsync())
                            {
                                await fstream.CopyToAsync(targetStream);
                            }

                            Uri imageUri = new Uri(targetFile.Path, UriKind.Absolute);

                            mc = new MessageContent(msg, msg.Sender, imageUri);
                        }
                        else
                        {
                            mc = new MessageContent(msg, msg.Sender, null);
                        }
                    }

                    this.Insert(0, mc);
                }

                uint loadCount = (uint)(newMsgs.Count());
                groupMessages.AddRange(newMsgs);
                Debug.WriteLine("Loaded: " + loadCount + " more messages");

                return new LoadMoreItemsResult { Count = loadCount };
            }
            finally
            {
                _busy = false;
            }
        }

        public bool HasMoreItems => true;

        public async void retrieveNewMessages()
        {
            //if (_busy)
            //{
            //    return;
            //}

            //_busy = true;

            //try
            {
                Debug.WriteLine("Checking for new messages");

                long fromTime;
                if (groupMessages.Any())
                {
                    fromTime = (long)groupMessages.First().CreationDate.Subtract(
                        new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds + 1;
                }
                else
                {
                    fromTime = 0;
                }

                var newMsgs = await msgApi.getGroupMessageDataAfter(groupId, fromTime, 10);

                StorageFolder storageFolder = ApplicationData.Current.LocalFolder;

                foreach (Message msg in newMsgs)
                {
                    MessageContent mc = getMessageContent(msg.id);

                    if (mc == null)
                    {
                        if (msg.GraphicsLocation == null)
                        {
                            mc = new MessageContent(msg, msg.Sender, null);
                        }
                        else
                        {
                            var fstream = await msgApi.getMessageFile(groupId, msg.id);

                            if (fstream != null && fstream.Length > 0)
                            {
                                StorageFile targetFile = await storageFolder.CreateFileAsync(msg.id + ".png", CreationCollisionOption.ReplaceExisting);
                                using (Stream targetStream = await targetFile.OpenStreamForWriteAsync())
                                {
                                    await fstream.CopyToAsync(targetStream);
                                }

                                Uri imageUri = new Uri(targetFile.Path, UriKind.Absolute);

                                mc = new MessageContent(msg, msg.Sender, imageUri);
                            }
                            else
                            {
                                mc = new MessageContent(msg, msg.Sender, null);
                            }
                        }

                        this.Add(mc);
                    }
                }

                uint loadCount = (uint)(newMsgs.Count());
                groupMessages.InsertRange(0, newMsgs.Reverse());
                Debug.WriteLine("Loaded: " + loadCount + " more messages");
                
            }
            //finally
            //{
            //    _busy = false;
            //}
        }

        public async void addNewItemAsync(string msgId)
        {
            //if (_busy)
            //{
            //    throw new InvalidOperationException("Only one operation in flight at a time");
            //}

            //_busy = true;

            //try
            {

                var msg = await msgApi.getMessage(msgId);

                if (msg != null && msg.id != null)
                {
                    MessageContent mc = getMessageContent(msg.id);
                    if (mc != null) return;

                    if (msg.GraphicsLocation != null)
                    {
                        StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
                        var fstream = await msgApi.getMessageFile(groupId, msg.id);

                        if (fstream != null && fstream.Length > 0)
                        {
                            StorageFile targetFile = await storageFolder.CreateFileAsync(msg.id + ".png", CreationCollisionOption.ReplaceExisting);
                            using (Stream targetStream = await targetFile.OpenStreamForWriteAsync())
                            {
                                await fstream.CopyToAsync(targetStream);
                            }

                            Uri imageUri = new Uri(targetFile.Path, UriKind.Absolute);

                            mc = new MessageContent(msg, msg.Sender, imageUri);
                        }
                        else
                        {
                            mc = new MessageContent(msg, msg.Sender, null);
                        }
                    }
                    else
                    {
                        mc = new MessageContent(msg, msg.Sender, null);
                    }

                    groupMessages.Insert(0, msg);
                    this.Add(mc);
                }
            }
            //finally
            //{
            //    _busy = false;
            //}
        }

        public void addMsgFile(string msgId)
        {
            var mc = getMessageContent(msgId);

            if (mc == null)
            {
                addNewItemAsync(msgId);
            }
            else
            {
                this.Remove(mc);
                addNewItemAsync(msgId);
            }
        }

        private MessageContent getMessageContent(string msgId)
        {
            foreach (MessageContent mc in this)
            {
                if (mc.msg.id == msgId)
                {
                    return mc;
                }
            }
            return null;
        }

        public new void Add(MessageContent mc)
        {
            base.Add(mc);
            groupMessages.Insert(0, mc.msg);
        }
    }
}
