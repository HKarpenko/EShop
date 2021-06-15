using e_Sport.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace e_Sport.Domain.UserAggregate.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        public IEnumerable<User> GetUserByRight(IEnumerable<UserRole> role);
    }
}
