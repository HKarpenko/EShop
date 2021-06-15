using e_Sport.Domain.UserAggregate;
using e_Sport.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace e_Sport.Application
{
    class UserServices : IUserServices
    {
        public UserIM users { get; private set; }

        public void CreateUserAdmin(User user)
        {
            user.ChangeUserRights(new List<UserRole> { UserRole.Admin });
            users.Add(user);
        }

        public void CreateUserCustomer(User user, bool IsLoggedIn)
        {
            user.IsLoggedIn = IsLoggedIn;
            if (IsLoggedIn)
            {
                user.ChangeUserRights(new List<UserRole> { UserRole.CustomerLogged });
            }
            else
            {
                user.ChangeUserRights(new List<UserRole> { UserRole.CustomerNotLogged });
            }
            users.Add(user);
        }

        public void DeleteUser(User user)
        {
            users.Remove(user);
        }

        public User GetCurrentUser()
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string email)
        {
            return users.FindWhere(new Predicate<User>(u => u.Email == email));
        }

        public User GetUserById(int id)
        {
            return users.FindWhere(new Predicate<User>(u => u.Id == id));
        }

        public void InitializeUserIM()
        {
            users = new UserIM();
        }

        public bool IsUserValid(User user)
        {
            return users.Find(user.Id) != null;
        }
    }
}
