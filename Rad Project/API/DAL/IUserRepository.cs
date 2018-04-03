using API.Models.Displayed_Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.DAL
{
    public interface IUserRepository:IDisposable
    {
        User GetUserByID(int userID);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int UserID);
        void Save();

    }
}