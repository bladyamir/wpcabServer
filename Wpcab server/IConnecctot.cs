﻿
using System.Threading.Tasks;
using WpcabServer.Model;

namespace WpcabServer
{
    interface IConnector
    {
         bool InsertUser(User user);

        Task<Response> GetUsersByPage(int page);

        User GetUserById(string id);

        bool EditUser(User user);
    }
}
