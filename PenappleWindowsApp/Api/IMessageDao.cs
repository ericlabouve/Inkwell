using PenscribCommon.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenappleWindowsApp.Api
{
    interface IMessageDao
    {
        /// <summary>
        /// Retrieve all message data associated with a group, this does
        /// not include the actual files
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns>a list of Message models</returns>
        Task<IEnumerable<Message>> getGroupMessageData(string groupId);

        /// <summary>
        /// Retrieve the file associated with an id
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="messageId"></param>
        /// <returns>Stream of the file data</returns>
        Task<Stream> getMessageFile(string groupId, string messageId);

        /// <summary>
        /// Send a file over HTTP
        /// </summary>
        /// <param name="fileStream"></param>
        /// <returns>the server generated id in a message</returns>
        Task<bool> sendMessageFile(Stream fileStream, string messageId);

        /// <summary>
        /// Send the data associated with a message. This should be called
        /// after sending the message file and retrieving the id
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        Task<Message> sendMessageData(Message msg);

        Task<IEnumerable<Message>> getGroupMessageDataBefore(string groupId, long before, int limit);

        Task<IEnumerable<Message>> getGroupMessageDataAfter(string groupId, long after, int limit);

        Task<IEnumerable<Message>> getGroupMessageData(string groupId, long before, long after, int limit);
    }
}
