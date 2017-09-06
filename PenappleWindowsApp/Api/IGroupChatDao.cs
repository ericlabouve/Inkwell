using PenscribCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PenappleWindowsApp.Api
{
    interface IGroupChatDao
    {
        /// <summary>
        /// Retrieve all group data for the specified userId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>a list of GroupChat models</returns>
        Task<IEnumerable<GroupChat>> getGroupsForUser(string userId);

        /// <summary>
        /// Post a newly created group chat to the server
        /// </summary>
        /// <param name="group">new group to post to server sans id</param>
        /// <returns>group chat with same information along with a generated id</returns>
        Task<GroupChat> postGroupChat(GroupChat group);

        Task<GroupChat> updateGroupChat(GroupChat group);

        Task<HttpResponseMessage> leaveGroupChat(GroupChat group, string userId);

        Task<GroupChat> renameGroupChat(GroupChat group, string newName); 
    }
}
