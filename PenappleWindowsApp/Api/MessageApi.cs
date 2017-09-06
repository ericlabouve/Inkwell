using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenscribCommon.Models;
using PenscribCommon.Helpers;
using System.Net.Http;

namespace PenappleWindowsApp.Api
{
    class MessageApi : IMessageDao
    {
        private static MessageApi instance;

        private MessageApi()
        {
            
        }

        /// <summary>
        /// Retrieve all message data associated with a group, this does
        /// not include the actual files
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns>a list of Message models</returns>
        public async Task<IEnumerable<Message>> getGroupMessageData(string groupId)
        {
            return await ApiHelper.GetAsync<IEnumerable<Message>>("message/group", groupId);
        }

        public async Task<IEnumerable<Message>> getGroupMessageDataBefore(string groupId, long before, int limit)
        {
            return await ApiHelper.GetAsyncQuery<IEnumerable<Message>>("message/group", groupId, new { to = before, num = limit, newestFirst = true });
        }

        public async Task<IEnumerable<Message>> getGroupMessageData(string groupId, long before, long after, int limit)
        {
            return await ApiHelper.GetAsyncQuery<IEnumerable<Message>>("message/group", groupId, new { from = after, to = before, num = limit, newestFirst = true });
        }

        public async Task<IEnumerable<Message>> getGroupMessageDataAfter(string groupId, long after, int limit)
        {
            return await ApiHelper.GetAsyncQuery<IEnumerable<Message>>("message/group", groupId, new { from = after, num = limit, newestFirst = false });
        }

        public async Task<Message> getMessage(string id)
        {
            return await ApiHelper.GetAsync<Message>("message", id);
        }

        /// <summary>
        /// Retrieve the file associated with an id
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="messageId"></param>
        /// <returns>Stream of the file data</returns>
        public async Task<Stream> getMessageFile(string groupId, string messageId)
        {
            var fileResponse = await ApiHelper.GetAsync("file", groupId, messageId);

            return await fileResponse.Content.ReadAsStreamAsync();
        }

        /// <summary>
        /// Send a file over HTTP
        /// </summary>
        /// <param name="fileStream"></param>
        /// <returns>the server generated id</returns>
        public async Task<Message> sendMessageData(Message msg)
        {
            return await ApiHelper.PostAsync<Message, Message>("message", msg);
        }

        /// <summary>
        /// Send the data associated with a message. This should be called
        /// after sending the message file and retrieving the id
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public async Task<bool> sendMessageFile(Stream fileStream, string messageId)
        {
            var response = await ApiHelper.PostStreamAsync<Message>("file", messageId, fileStream);
            return response.IsSuccessStatusCode;
        }

        public static MessageApi getInstance()
        {
            if (instance == null)
            {
                instance = new MessageApi();
            }
            return instance;
        }
    }
}
