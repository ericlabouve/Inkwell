using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenscribCommon.Models;
using PenscribCommon.Helpers;
using System.Net.Http;

namespace PenappleWindowsApp.Api
{
    class GroupChatApi : IGroupChatDao
    {
        private static GroupChatApi instance;

        private GroupChatApi()
        {

        }

        /// <summary>
        /// Retrieve all group data for the specified userId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>a list of GroupChat models</returns>
        public async Task<IEnumerable<GroupChat>> getGroupsForUser(string userId)
        {
            return await ApiHelper.GetAsync<IEnumerable<GroupChat>>("groupchat/user", userId);
        }

        /// <summary>
        /// Post a newly created group chat to the server
        /// </summary>
        /// <param name="group">new group to post to server sans id</param>
        /// <returns>group chat with same information along with a generated id</returns>
        public async Task<GroupChat> postGroupChat(GroupChat group)
        {
            return await ApiHelper.PostAsync<GroupChat, GroupChat>("groupchat", group);
        }

        public static GroupChatApi getInstance()
        {
            if (instance == null)
            {
                instance = new GroupChatApi();
            }
            return instance;
        }

        public async Task<GroupChat> updateGroupChat(GroupChat group)
        {
            return await ApiHelper.PostAsync<GroupChat, GroupChat>("groupchat/update", group);
        }

        /// <summary>
        /// Leave the existing groupchat on the server
        /// </summary>
        /// <param name="group"></param>
        /// <param name="userId">The current user of the app</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> leaveGroupChat(GroupChat group, string userId)
        {
            return await ApiHelper.DeleteAsync($"groupchat/leave/{userId}/{group.id}");
        }

        /// <summary>
        /// Rename the gorup chat
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public async Task<GroupChat> renameGroupChat(GroupChat group, string newName)
        {
            var response = await ApiHelper.PutAsync($"groupchat/{group.id}/name", newName);
            if (response.IsSuccessStatusCode)
            {
                return await ApiHelper.GetAsync<GroupChat>("groupchat", group.id);
            }
            else
            {
                return null;
            }
        }
    }
}
