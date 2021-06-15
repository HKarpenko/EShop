using e_Sport.Domain.UserAggregate;
using System.Linq;
using System.Collections.Generic;

namespace e_Sport.Infrastructure.Repositories
{
    public class UserIM : GenericIM<User>, e_Sport.Domain.UserAggregate.Repositories.IUserRepository
    {
        public UserIM()
        {
            instances.Add(new User("John Doe", "john.doe@email.com"));
            instances.Add(new User("Sara Doe", "sara.doe@email.com"));
            instances.Add(new User("Sam Doe", "john.doe@email.com"));
        }
        public IEnumerable<User> GetUserByRight(IEnumerable<UserRole> role)
        {
            return instances.Where(u => role.All(r => u.Roles.Contains(r)));
        }
    }
}
