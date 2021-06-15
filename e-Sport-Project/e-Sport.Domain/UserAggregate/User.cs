using System.Linq;
using System.Collections.Generic;
using System.Text;
using e_Sport.Domain.Interfaces;

namespace e_Sport.Domain.UserAggregate
{
    public class User : IEntity
    {
        private static int counter = 1;
        public User(string name, string email)
        {
            UserName = name;
            Email = email;
            Id = counter;
            counter++;
            Basket = new Basket(this);
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string HashPassword { get; set; }
        public string PhoneNumber { get; set; }
        public Adress Adress { get; set; }
        public bool IsLoggedIn { get; set; }
        public IEnumerable<UserRole> Roles { get; private set; }
        public Basket Basket { get; private set; }
        public bool ChangeUserRights(IEnumerable<UserRole> newUserRights)
        {
            Roles = newUserRights;
            return true;
        }
        public bool isAdmin()
        {
            if (Roles.Contains(UserRole.Admin))
            {
                return true;
            }
            return false;
        }
        public string getDefaultDelivery()
        {
            if (Adress != null)
                return "DHL";
            return "InPost";
        }
    }
}
