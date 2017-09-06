using PenscribCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenappleWindowsApp.Api
{
    interface IUserDao
    {
        /// <summary>
        /// Retrieve a specified user's information
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>a User model</returns>
        Task<User> getUser(string userId);
    }
}
