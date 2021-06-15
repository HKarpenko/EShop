using System;
using System.Collections.Generic;
using System.Text;
using e_Sport.Domain.UserAggregate;

namespace e_Sport.Application
{
    interface IUserServices
    {
        public void InitializeUserIM();
        public void CreateUserCustomer(User user, bool IsLoggedIn);
        public void CreateUserAdmin(User user);
        public User GetUserById(int id);
        public bool IsUserValid(User user);
        public void DeleteUser(User user);
        public User GetCurrentUser();
        public User GetUserByEmail(string email);
    }
}
