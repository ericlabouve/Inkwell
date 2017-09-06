using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenscribCommon.Models;
using PenscribCommon.Helpers;

namespace PenappleWindowsApp.Api
{
    class UserApi : IUserDao
    {
        private static UserApi instance;

        private UserApi()
        {

        }

        public async Task<User> getUser(string userId)
        {
            return await ApiHelper.GetAsync<User>("user", userId);
        }

        public async Task<User> getUserByEmail(string email)
        {
            return await ApiHelper.GetAsyncQuery<User>("User", new { Email = email });
        }

        public static UserApi getInstance()
        {
            if (instance == null)
            {
                instance = new UserApi();
            }

            return instance;
        }
    }
}
